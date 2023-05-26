using System;

public class PasswordLoginService : LoginService
{
	public const string kAuthTokenSaveKey = "sgAccessToken";

	private Action<LoginResult> callback;

	private PasswordLoginData loginData;

	private bool showCreationMessage;

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

	public override void SaveAuthToken(string token)
	{
	}

	public override AuthenticateRequest GetAuthenticationRequest()
	{
		return null;
	}

	public override void PerformPostAuthTasks(Action callback)
	{
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

	private void OnPopupCompleted()
	{
	}

	private void OnPopupCanceled()
	{
	}
}
