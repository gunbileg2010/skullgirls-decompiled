public class OfflineLoginService : LoginService
{
	public override AuthenticateRequest GetAuthenticationRequest()
	{
		return null;
	}
}
