using BussinessLayer;
using Castle.Core.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using System.Security.Claims;

namespace BusBookingRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusBookingRestController : ControllerBase
    {
        private readonly ICustomersBLL _customersBLL;


        public BusBookingRestController(ICustomersBLL customersBLL)
        {
            _customersBLL = customersBLL;
        }

        /* [HttpPost("AddCustomer", Name = "AddNewCustomer")]
         [ProducesResponseType(StatusCodes.Status201Created)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
         public ActionResult<Customers> AddCustomer([FromBody] Customers customers)
         {
             if (!ModelState.IsValid)
                 return BadRequest(ModelState);

             if (customers == null || string.IsNullOrWhiteSpace(customers.FullName))
                 return BadRequest("Customer data is invalid");

             _customersBLL.CurrentCustomer = customers;

             if (_customersBLL.Save())
             {
                 return Created("", customers);
             }

             return BadRequest("Error while saving customer");
         }*/


        /*[HttpPost("Customers/Login", Name = "CustomersLogin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<CustomerDTOForLogin> CustomersForLogin([FromBody] ModelsLayer.Api_DTO_S.LoginCustomers customers)
        {
            try
            {
                if (string.IsNullOrEmpty(customers.PhoneNumber) || string.IsNullOrEmpty(customers.Password))
                {
                    return BadRequest("Phone number and password are required");
                }
                //return BadRequest(new
                //{
                //    PhoneReceived = customers.PhoneNumber,
                //    PasswordReceived = customers.Password
                //});

                var customer = _customersBLL.GetCustomerForLogin(customers.PhoneNumber, customers.Password);

                if (customer != null)
                {
                    var dto = new CustomerDTOForLogin
                    {
                        CustomerID = customer.CustomerID,
                        PhoneNumber = customer.PhoneNumber,
                        FullName = customer.FullName,
                        Email = customer.Email,
                        IsActive = customer.IsActive,
                        DateOfBirth = customer.DateOfBirth,
                        CountryId = customer.CountryId
                    };
                    return Ok(dto);
                }
                else
                    return NotFound("Customer not found");
            }
            catch (Exception ex)
            {
                // يمكنك إضافة تسجيل للخطأ هنا
                return StatusCode(500, "Internal server error");
            }
        }*/


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

                return Ok(customer);
            
        }

        
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
        public async Task<ActionResult<IEnumerable<string>>> GetNationaTrips()
        {
            List<string> NationaTrips = await TripBLL.GetNationalTripsName();
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
        public async Task<ActionResult<IEnumerable<string>>> GetInternationalTrips()
        {
            List<string> InterNationaTrips = await TripBLL.GetInterNationalTripsName();
            if (InterNationaTrips.Count > 0)
            {
                return Ok(InterNationaTrips);
            }
            else
            {
                return NotFound("No International Trips found");
            }
        }


        [HttpGet("GetTripName/{TripName}", Name = "GetTripNameByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> GetTripIdByName(string TripName)
        {
            if(string.IsNullOrWhiteSpace(TripName))
            {
                return BadRequest("Trip Name Cannot Be empty");
            }

            int Trip = 0;
            Trip = await TripBLL.GetTripIDByName(TripName);
            if (Trip != 0)
            {
                return Ok(Trip);
            } 
            else if(Trip == 0)
            {
                return BadRequest("Trip Equal 0");
            }
            else
            {
                return NotFound("No Trip Found");
            }
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
            }else
            {
                return NotFound("No trip found");
            }
        }


        [Authorize]
        [HttpPost("BookFromClient", Name = "BookFromClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BookingResponseDTO>> BookFromClient([FromBody] CompleteBookingDTO data)
        {
            if (data == null || data.Booking == null || data.Tickets == null)
                return BadRequest("Booking data is invalid");

            var bookingBLL = new BookingsBLL
            {
                CurrentBooking = data.Booking
            };

            bool result = await bookingBLL.SaveCompleteAsync(data.Tickets, data.Payments);

            if (result)
                return Created("", new BookingResponseDTO { BookingID = bookingBLL.CurrentBooking.BookingID });

            return BadRequest("Error while saving booking");
        }


        [Authorize]
        [HttpGet("GetAllBooks/{customerId}", Name = "GetAllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<BooksDTO>>> GetAllBooksForCustomer(int customerId, [FromServices] IAuthorizationService authorizationService)
        { // جلب الـ claim من التوكن للتأكد قبل أي عملية (optional but safe)
            var customerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(customerIdClaim) || !int.TryParse(customerIdClaim, out int authenticatedCustomerId) || authenticatedCustomerId < 1)
            {
                return BadRequest("Invalid token.");
            }

            var authResult = await authorizationService.AuthorizeAsync(User, customerId, "ClientOwnerOrAdmin");
            if (!authResult.Succeeded)
                return Forbid();

            List<BooksDTO> books = await BookingsBLL.GetBooksDTOs(customerId);
            if (books.Count > 0)
            {
                return Ok(books);
            }
            else
            {
                return NotFound("No trips found");
            }
        }
    }
}
