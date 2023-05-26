using System;
using System.Collections.Generic;

public class BindAccountRequest : NetworkRequest
{
	private LoginType kind;

	private string accountId;

	private string password;

	private AccountServerData account;

	private List<Reward> rewards;

	public BindAccountRequest(LoginType kind, string accessToken)
	{
	}

	public BindAccountRequest(LoginType kind, string accountId, string password)
	{
	}

	public override void Send(Action callback)
	{
	}

	public AccountServerData GetAccountData()
	{
		return null;
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
