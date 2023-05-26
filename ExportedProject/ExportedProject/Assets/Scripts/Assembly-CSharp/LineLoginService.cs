using System;

public class LineLoginService : LoginService
{
	public const string kChannelId = "1567118850";

	public static string GetChannelId()
	{
		return null;
	}

	public override void Init()
	{
	}

	public override void Login(bool newUser, Action<LoginResult> callback)
	{
	}

	public override void Logout()
	{
	}

	public override string GetAuthToken()
	{
		return null;
	}

	public override AuthenticateRequest GetAuthenticationRequest()
	{
		return null;
	}

	public override bool CanBind()
	{
		return false;
	}

	public override BindAccountRequest GetBindRequest()
	{
		return null;
	}

	public override void LogBindImpression()
	{
	}

	public override void LogBindConversion()
	{
	}
}
