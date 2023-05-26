using System;
using System.Collections.Generic;

public class SkipEventRequest : NetworkRequest
{
	private List<RewardServerData> rewardServerDatas;

	private string eventInstanceId;

	public SkipEventRequest(string eventInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<RewardServerData> GetRewardServerDatas()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
