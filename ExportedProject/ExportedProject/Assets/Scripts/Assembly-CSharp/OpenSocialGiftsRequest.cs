using System;
using System.Collections.Generic;

public class OpenSocialGiftsRequest : NetworkRequest
{
	private List<RewardServerData> rewardServerData;

	private List<Reward> rewards;

	public override void Send(Action callback)
	{
	}

	public List<RewardServerData> GetRewardServerData()
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
