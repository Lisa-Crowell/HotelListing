namespace HotelListing.API.Models.User;

public class AuthResponseDto
{
    public string RefreshToken { get; set; }
    public string UserId { get; set; }
    public string Token { get; set; }
}