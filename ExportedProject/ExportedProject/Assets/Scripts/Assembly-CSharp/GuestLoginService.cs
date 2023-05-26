public class GuestLoginService : LoginService
{
	public const string kAuthTokenSaveKey = "guestAuthToken";

	public override void Logout()
	{
	}

	public override string GetAuthToken()
	{
		return null;
	}

	public override void SaveAuthToken(string token)
	{
	}

	public override AuthenticateRequest GetAuthenticationRequest()
	{
		return null;
	}
}
