using System;
using Google;

public class GoogleLoginService : LoginService
{
	private Action<LoginResult> callback;

	private GoogleSignInUser googleSignInUser;

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

	private void OnGoogleLoginSucceeded()
	{
	}

	private void OnGoogleLoginFailed(bool userCanceled = false)
	{
	}
}
