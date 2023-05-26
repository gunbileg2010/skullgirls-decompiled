using System;
using System.Collections.Generic;

public class EvolveCharacterRequest : NetworkRequest
{
	private string backendId;

	private List<string> sacrificeBackendIds;

	private List<RewardServerData> rewards;

	public EvolveCharacterRequest(Character character, List<Character> sacrifices)
	{
	}

	public List<RewardServerData> GetRewards()
	{
		return null;
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
