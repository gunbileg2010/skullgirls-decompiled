using System;
using AppleAuth;
using AppleAuth.Interfaces;

public class AppleLoginService : LoginService
{
	private Action<LoginResult> callback;

	private const string kAppleUserIdKey = "appleUserId";

	private const string kAppleAccountNameKey = "appleAccountName";

	private const string kAuthTokenSaveKey = "appleAuthToken";

	private IAppleAuthManager appleAuthManager;

	private IAppleIDCredential appleIdCredential;

	private bool quickLoginAlreadyFailedOnce;

	public override void Init()
	{
	}

	public override void Update()
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

	public override void SaveAuthToken(string token)
	{
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

	private void OnAppleLoginSucceeded()
	{
	}

	private void OnAppleLoginFailed(IAppleError error)
	{
	}

	private void CheckCredentialStatusForUserId(string appleUserId, Action<bool> callback)
	{
	}

	private void AttemptLogin()
	{
	}

	private void LoginWithAppleId()
	{
	}

	private bool CacheCredentials(ICredential credential)
	{
		return false;
	}

	private void LogAppleError(IAppleError error)
	{
	}
}
