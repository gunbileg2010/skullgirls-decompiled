using System;
using System.Collections.Generic;

public class ClaimAchievementRequest : NetworkRequest
{
	private string achievementId;

	private List<Reward> rewards;

	public ClaimAchievementRequest(string id)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
