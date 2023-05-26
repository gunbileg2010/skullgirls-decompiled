using System;
using System.Collections.Generic;

public class PowerupCharacterRequest : NetworkRequest
{
	private string characterId;

	private string[] foodCharactersIds;

	private Dictionary<string, int> infoOnConsumablesToConsume;

	private List<RewardServerData> rewards;

	public PowerupCharacterRequest(Character character, List<Character> foodCharacters, Dictionary<string, int> infoOnConsumablesToConsume)
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
