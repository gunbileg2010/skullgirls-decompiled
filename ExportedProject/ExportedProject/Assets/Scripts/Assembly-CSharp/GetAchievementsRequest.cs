using System;
using System.Collections.Generic;

public class GetAchievementsRequest : NetworkRequest
{
	private List<Achievement> achievements;

	public override void Send(Action callback)
	{
	}

	public List<Achievement> GetAchievements()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
