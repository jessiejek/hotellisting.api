namespace hotellisting.api.Models.Users
{
    public class AuthResponseDto
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public string RefreshToken { get; set; }
    }
}
