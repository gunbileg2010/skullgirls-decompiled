using System;
using System.Collections.Generic;

public class AuthenticateRequest : NetworkRequest
{
	private string authToken;

	private LoginType provider;

	private string accountId;

	private string accountName;

	private string password;

	private bool createNewUser;

	private string newUserTag;

	private string identityToken;

	private string authCode;

	private SessionServerData sessionData;

	private UserServerData userData;

	private RewardCalendarStatesServerData loginRewardCalendarData;

	public AuthenticateRequest(LoginType provider)
	{
	}

	public AuthenticateRequest(LoginType provider, string authToken)
	{
	}

	public AuthenticateRequest(LoginType provider, string identityToken, string authCode, string accountName)
	{
	}

	public AuthenticateRequest(LoginType provider, string email, string password)
	{
	}

	public void SetCreateNewUser(bool createNewUser)
	{
	}

	public bool GetCreateNewUser()
	{
		return false;
	}

	public void SetNewUserTag(string tag)
	{
	}

	public LoginType GetLoginProvider()
	{
		return default(LoginType);
	}

	public override void Send(Action callback)
	{
	}

	public SessionServerData GetSessionData()
	{
		return null;
	}

	public UserServerData GetUserData()
	{
		return null;
	}

	public List<RewardCalendarStateServerData> GetRewardCalendars()
	{
		return null;
	}

	public List<RewardCalendarStateServerData> GetLoginCalendarsWithRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}

	private void OnOfflineResponse(HttpResponse response)
	{
	}

	private bool ProcessResponse(HttpResponse response)
	{
		return false;
	}

	private static string ParseSetCookieHeaders(string setCookieHeader)
	{
		return null;
	}
}
