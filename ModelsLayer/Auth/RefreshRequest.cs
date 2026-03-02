namespace StudentApi.Model.Auth
{
    public class RefreshRequest
    {
        public string RefreshToken { get; set; }
        public string PhoneNumber { get; set; }
    }
}
