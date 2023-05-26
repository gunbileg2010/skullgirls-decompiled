using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
	public enum LoginError
	{
		CantRefreshLogin = 0,
		PlatformLoginUserCanceled = 1,
		PlatformLoginFailed = 2,
		BackendAuthFailed = 3,
		UserSuspended = 4,
		UserBanned = 5,
		InvalidUsernamePassword = 6,
		UsernameIsTaken = 7,
		BindingAccountAlreadyUsed = 8,
		BindingAccountNotFound = 9
	}

	private const string kHasLoggedInBeforeKey = "loggedInBefore";

	private const string kLastLoginTypeKey = "lastLoginType";

	private const string kDeviceIdKey = "deviceId";

	private bool loggedInToBackend;

	private LoginType lastAttemptedLoginType;

	private LoginType currentLoginType;

	private Dictionary<LoginType, LoginService> loginServices;

	private float lastPingTime;

	private List<RewardCalendarStateServerData> waitingLoginCalendarRewards;

	private const string kNextGuestWarningTimeKey = "guestWarningTime";

	private const int kDaysUntilNextGuestWarning = 1;

	public event Action<AuthenticateRequest> LoginSucceeded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<LoginType, LoginError, string, string> LoginFailed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string> LoginStatusChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action LoggedOut
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void Update()
	{
	}

	public bool IsLoginServiceSupported(LoginType loginType)
	{
		return false;
	}

	public void Login(LoginType loginType, bool newUser)
	{
	}

	public void RefreshLogin()
	{
	}

	public void Logout()
	{
	}

	public void Bind(LoginType loginType, Action<bool> callback)
	{
	}

	public bool IsLoggedInWith(LoginType loginType)
	{
		return false;
	}

	public bool IsLoggedInToBackend()
	{
		return false;
	}

	public bool IsOnline()
	{
		return false;
	}

	public bool HasLoggedInBefore()
	{
		return false;
	}

	public void ForceBackToLoginScreen(bool showSessionExpiredPopup)
	{
	}

	public LoginType GetPrimaryLoginType()
	{
		return default(LoginType);
	}

	public LoginType GetLastAttemptedLoginType()
	{
		return default(LoginType);
	}

	public string GetDeviceId()
	{
		return null;
	}

	public string GetAccessToken()
	{
		return null;
	}

	public string GetRegionCode()
	{
		return null;
	}

	public List<RewardCalendarStateServerData> GetWaitingLoginRewards()
	{
		return null;
	}

	public bool ShouldDisplayGuestWarning()
	{
		return false;
	}

	public void UpdateNextGuestWarningTime()
	{
	}

	private void LoginInternal(LoginType loginType, bool newUser, bool autoLogin)
	{
	}

	private void SetPrimaryLoginType(LoginType loginType)
	{
	}

	private void AuthenticateToBackend(LoginType loginType, bool newUser, bool autoLogin)
	{
	}

	private void PerformPostAuthenticationTasks(LoginType loginType, AuthenticateRequest authenticateRequest, bool autoLogin)
	{
	}

	private void FireLoginSucceeded(AuthenticateRequest authorizeRequest, bool autoLogin)
	{
	}

	private void FireLoginFailed(LoginType loginType, LoginError error, string errorCode = null, string errorMessage = null)
	{
	}

	private IEnumerator DoForceBackToLoginScreen(bool displayPopup)
	{
		return null;
	}
}
