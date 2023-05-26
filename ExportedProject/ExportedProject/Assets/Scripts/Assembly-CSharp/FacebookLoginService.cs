using System;
using Prime31;

public class FacebookLoginService : LoginService
{
	private Action<LoginResult> callback;

	private bool forceLoginRefresh;

	public override void Init()
	{
	}

	public override void Shutdown()
	{
	}

	public override void Login(bool newUser, Action<LoginResult> callback)
	{
	}

	public void ForceRefreshOnNextLogin()
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

	private void OnFacebookLoginSucceeded()
	{
	}

	private void OnFacebookLoginFailed(P31Error error)
	{
	}
}
