using System;
using System.Collections.Generic;

public class GetCollectionRequest : NetworkRequest
{
	private FullUserDataType dataFlags;

	public CharacterServerData[] characters;

	public string[] competitiveTeamGuids;

	public GearServerData[] gears;

	public Dictionary<string, object> competitiveEquippedMoves;

	public CollectibleNodeModifierServerData[] nodeModifiers;

	public Dictionary<string, List<string>> eventLockedCharacterIdMap;

	public GetCollectionRequest(FullUserDataType dataFlags = FullUserDataType.All)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}

	private bool ProcessResponse(HttpResponse response)
	{
		return false;
	}
}
