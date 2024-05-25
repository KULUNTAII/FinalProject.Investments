using System.Security.Claims;
public interface IAuthService
{
    public ClaimsIdentity CreateClaimsIdentity(UserGetDto user);
    public string GenerateJwt(ClaimsIdentity claimsIdentity);
}
