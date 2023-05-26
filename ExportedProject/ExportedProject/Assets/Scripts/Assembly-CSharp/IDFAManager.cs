using System;
using System.Collections;

public class IDFAManager : MonoSingleton<IDFAManager>
{
	public enum IDFAAuthorizationStatus
	{
		NotDetermined = 0,
		Restricted = 1,
		Denied = 2,
		Authorized = 3
	}

	private bool idfaSupported;

	protected override void Awake()
	{
	}

	public IDFAAuthorizationStatus GetIDFAStatus()
	{
		return default(IDFAAuthorizationStatus);
	}

	public void PromptForIDFAPermission(Action callback)
	{
	}

	public bool SupportsIDFA()
	{
		return false;
	}

	private IEnumerator DoPromptForIDFAPermission(Action callback)
	{
		return null;
	}

	public IDFAManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
