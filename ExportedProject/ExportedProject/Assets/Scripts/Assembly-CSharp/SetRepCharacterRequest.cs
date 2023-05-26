using System;

public class SetRepCharacterRequest : NetworkRequest
{
	private string characterId;

	public SetRepCharacterRequest(Character character)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
