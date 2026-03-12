using BussinessLayer;
using Castle.Core.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using ModelsLayer.Api_DTO_S;
using System.Collections.Generic;
using System.Security.Claims;

namespace BusBookingRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusBookingRestController : ControllerBase
    {
        private readonly ICustomersBLL _customersBLL;
        private readonly IBookingsBLL  _bookingBLL;


        public BusBookingRestController(ICustomersBLL customersBLL , IBookingsBLL bookingsBLL)
        {
            _customersBLL = customersBLL;
            _bookingBLL = bookingsBLL;
        }

        #region Customer
        [Authorize]
        [HttpGet("MyProfile", Name = "Profile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Customers>> GetProfile([FromServices] IAuthorizationService authorizationService)
        {
            // هذا الكود ضروري 
            // secure api for student project وغاد بحدد الصلاحيات لانه احنا هون بدنا بس صاحب الحساب يوصله لو بدنا صاحب الحساب والادمن بنسوي زي الطريقة الي في مشروع ال Authorization check عشان نتحقق من الكلايم اذا تمام بنروح على الهاندلر عشان ال
            var customerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool isValidCustomerId = int.TryParse(customerIdClaim, out int customerId);

            if (string.IsNullOrEmpty(customerIdClaim) || !isValidCustomerId || customerId < 1)
            {
                return BadRequest("invalid token");
            }

            // Authorization check | [Authorize(Policy = "ClientOwnerOrAdmin")] بس هون بطل الها داعي لانه في
            var authResult = await authorizationService.AuthorizeAsync(User, customerId, "ClientOwnerOrAdmin");
            if (!authResult.Succeeded)
                return Forbid();

            var customer = await _customersBLL.GetCustomerByID(customerId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }

            await _bookingBLL.GetAllBooksDTOForCustomer(customerId);
            var (updateSuccess, errorMessage) = await _bookingBLL.UpdateCustomerStats(customer);

            if (updateSuccess)
                return Ok(customer); // 200 OK دائماً إذا العميل موجود
            else
                return BadRequest(errorMessage ?? "Error while updating customer stats");
        }

        [Authorize]
        [HttpPut("UpdateProfile", Name = "UpdateProfile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateProfile([FromForm] UpdateProfileDTO dto)
        {
            var customerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(customerIdClaim, out int customerId) || customerId < 1)
                return BadRequest("Invalid token");

            var customer = await _customersBLL.GetCustomerByID(customerId);

            if (customer == null)
                return NotFound("Customer not found");

            // تحديث البيانات الأساسية
            customer.FullName = dto.FullName;
            customer.PhoneNumber = dto.PhoneNumber;
            customer.Email = dto.Email;
            customer.Discription = dto.Description;

            // تحديث الصورة عبر Helper
            bool updated = await _customersBLL.UpdateProfileWithImage(customer, dto.Image);

            if (!updated)
                return BadRequest("Update failed or invalid image");

            return Ok(customer);
        }

        [HttpGet("GetCustomerImage/{fileName}")]
        public IActionResult GetCustomerImage(string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "customers", fileName);
            if (!System.IO.File.Exists(path)) return NotFound();
            var contentType = "image/jpeg"; // أو type ديناميكي
            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, contentType);
        }
        #endregion

        #region Trip Endpoints
        [HttpGet("GetAllTrips", Name = "GetAllTrips")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<TripDTO>> GetTrips()
        {
            List<TripDTO> trips = TripBLL.GetTripDTOs();
            if (trips.Count > 0)
            {
                return Ok(trips);
            }
            else
            {
                return NotFound("No trips found");
            }
        }

        [HttpGet("GetNationalTrips", Name = "GetNationalTrips")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Trip_IDName>>> GetNationaTrips()
        {
            List<Trip_IDName> NationaTrips = await TripBLL.GetNationalTripsName();
            if (NationaTrips.Count > 0)
            {
                return Ok(NationaTrips);
            }
            else
            {
                return NotFound("No National Trips found");
            }
        }

        [HttpGet("GetInternationalTrips", Name = "GetInternationalTrips")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Trip_IDName>>> GetInternationalTrips()
        {
            List<Trip_IDName> InterNationaTrips = await TripBLL.GetInterNationalTripsName();
            if (InterNationaTrips.Count > 0)
            {
                return Ok(InterNationaTrips);
            }
            else
            {
                return NotFound("No International Trips found");
            }
        }

        [HttpGet("GetAllTripTimes/{tripTimeId}")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllTripTimes(short tripTimeId)
        {
            var tripTimesList = await TripTimesBLL.GetAllTripTimes(tripTimeId);
            if (tripTimesList.Count == 0)
                return NotFound("No Trip Times Found");

            // دمج كل الأعمدة Time1..Time7 في قائمة واحدة
            var times = tripTimesList
                .SelectMany(tt => new List<TimeSpan?> { tt.Time1, tt.Time2, tt.Time3, tt.Time4, tt.Time5, tt.Time6, tt.Time7 })
                .Where(t => t.HasValue) // نتجاهل الفراغات
                .Select(t => t.Value.ToString(@"hh\:mm")) // تحويل للـ "HH:mm"
                .ToList();

            return Ok(times);
        }

        [HttpGet("GetTripName/{TripName}", Name = "GetTripNameByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> GetTripIdByName(string TripName)
        {
            if (string.IsNullOrWhiteSpace(TripName))
            {
                return BadRequest("Trip Name Cannot Be empty");
            }

            int Trip = 0;
            Trip = await TripBLL.GetTripIDByName(TripName);
            if (Trip != 0)
            {
                return Ok(Trip);
            }
            else if (Trip == 0)
            {
                return BadRequest("Trip Equal 0");
            }
            else
            {
                return NotFound("No Trip Found");
            }
        }

        [HttpPost("GetMoneyAmount", Name = "GetMoneyAmount")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTotalTripAmount([FromBody] CalculateTotalTripAmount calculateTotal)
        {
            if (calculateTotal.childCount <= 0 && calculateTotal.adultCount <= 0 && calculateTotal.disabledCount <= 0 && calculateTotal.tripName == "")
            {
                return BadRequest("No Content");
            }
            decimal totalTripAmount = await _bookingBLL.CalculateTotalAmount(calculateTotal.tripName, calculateTotal.adultCount, calculateTotal.childCount, calculateTotal.disabledCount);
            return Ok(totalTripAmount);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("GetTripDTOByName/{TripName}", Name = "GetTripDTOByName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TripDTO>> GetTripDTOByName(string TripName)
        {
            TripDTO trip = await TripBLL.GetTripDTOByName(TripName);

            if (trip != null)
            {
                var dto = new TripDTO
                {
                    TripID = trip.TripID,
                    IsInternational = trip.IsInternational,
                    TripDate = trip.TripDate,
                    DepartureTime = trip.DepartureTime,
                    ArrivalTime = trip.ArrivalTime,
                    Price = trip.Price,
                    AvailableSeats = trip.AvailableSeats,
                    Status = trip.Status,
                    Route = trip.Route,
                    Bus = trip.Bus,
                    TripName = trip.TripName,
                    Class = trip.Class,
                    CreatedByUser = trip.CreatedByUser,
                };

                return Ok(dto);
            }
            else
            {
                return NotFound("No trip found");
            }
        }
        #endregion


        #region Book Endpoints
        [Authorize]
        [HttpPost("BookFromClient", Name = "BookFromClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BookingResponseDTO>> BookFromClient([FromBody] CompleteBookingDTO data)
        {
            if (data == null || data.Booking == null || data.Tickets == null)
                return BadRequest("Booking data is invalid");

            int customerId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            data.Booking.CustomerID = customerId;

            bool result = await _bookingBLL.SaveCompleteAsync(data.Booking, data.Tickets, data.Payments);

            if (result)
                return Created("", new BookingResponseDTO { });

            return BadRequest("Error while saving booking");
        }

        [Authorize]
        [HttpGet("GetAllBooksForCustomer", Name = "GetAllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<BooksDTO>>> GetAllBooksForCustomer()
        {
            var customerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(customerIdClaim) || !int.TryParse(customerIdClaim, out int customerId) || customerId < 1)
            {
                return BadRequest("Invalid token.");
            }

            List<BooksDTO> books = await _bookingBLL.GetAllBooksDTOForCustomer(customerId);
            if (books.Count > 0)
                return Ok(books);

            return NotFound("No trips found");
        }

        [Authorize]
        [HttpGet("GetTicketsForBooking/{bookingId}", Name = "GetAllTickets")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<BooksDTO>>> GetTicketsForBooking(int bookingId)
        {
            // 1- جلب الـ CustomerId من الـ JWT
            var customerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(customerIdClaim) || !int.TryParse(customerIdClaim, out int customerId) || customerId < 1)
                return BadRequest("Invalid token.");

            // 2- تحقق أن هذا الحجز يخص المستخدم الحالي
            bool isOwner = await _bookingBLL.IsBookingOwnedByCustomer(bookingId, customerId);
            if (!isOwner)
                return Forbid();

            // 3- جلب التذاكر إذا كانت ملكاً للمستخدم
            List<TicketsDTO> tickets = await TicketsBLL.GetTicketByBookingId(bookingId);
            if (tickets == null || tickets.Count == 0)
                return NotFound("No tickets found for this booking.");

            return Ok(tickets);
        }

        [HttpGet("GetBookedSeats/{tripId}", Name = "GetBookedSeats")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<byte>>> GetBookedSeats(int tripId)
        {
            List<byte> BookedSeats = await TicketsBLL.AllBookedSeats(tripId);
            if (BookedSeats.Count > 0)
            {
                return Ok(BookedSeats);
            }
            else
            {
                return NotFound("No Booked Seats found");
            }
        }
        #endregion


        #region Countries Endpoints
        [HttpGet("GetCountries", Name = "GetCountries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCountries()
        {
            var countries = await CustomerCountriesBLL.GetCountries();

            return Ok(countries);
        }

        [HttpGet("GetCountrNameById/{countryId}", Name = "GetCountrNameById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCountrNameById(short countryId)
        {
            var CountryId = await CustomerCountriesBLL.GetCountryNameById(countryId);

            return Ok(CountryId);
        } 
        #endregion
    }
}
