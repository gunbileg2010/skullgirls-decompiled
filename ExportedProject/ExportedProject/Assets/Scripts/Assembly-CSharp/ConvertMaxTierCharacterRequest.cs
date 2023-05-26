using System;
using System.Collections.Generic;

public class ConvertMaxTierCharacterRequest : NetworkRequest
{
	private string characterInstanceId;

	private List<Reward> rewards;

	public ConvertMaxTierCharacterRequest(string characterInstanceId)
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
