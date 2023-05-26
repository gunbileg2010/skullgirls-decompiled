using System;
using System.Collections.Generic;

public class OpenGachasRequest : NetworkRequest
{
	protected string gachaGuid;

	protected int amount;

	private GachaOpenServerData gachaOpenServerData;

	public OpenGachasRequest(string inGachaGuid, int inAmount)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<List<Reward>> GetRewardsPerGacha()
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

	protected virtual void DEBUG_Send(Action callback)
	{
	}
}
