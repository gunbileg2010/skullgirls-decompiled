using System;

public abstract class LoginService
{
	public enum LoginResult
	{
		Success = 0,
		Failure = 1,
		Canceled = 2
	}

	public virtual void Init()
	{
	}

	public virtual void Shutdown()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void Login(bool newUser, Action<LoginResult> callback)
	{
	}

	public virtual void Logout()
	{
	}

	public virtual bool IsLoggedIn()
	{
		return false;
	}

	public virtual string GetAuthToken()
	{
		return null;
	}

	public virtual void SaveAuthToken(string token)
	{
	}

	public virtual AuthenticateRequest GetAuthenticationRequest()
	{
		return null;
	}

	public virtual void PerformPostAuthTasks(Action callback)
	{
	}

	public virtual bool CanBind()
	{
		return false;
	}

	public virtual BindAccountRequest GetBindRequest()
	{
		return null;
	}

	public virtual void LogBindImpression()
	{
	}

	public virtual void LogBindConversion()
	{
	}
}
