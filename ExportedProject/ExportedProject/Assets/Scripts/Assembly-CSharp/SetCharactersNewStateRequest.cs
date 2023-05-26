using System;
using System.Collections.Generic;

public class SetCharactersNewStateRequest : NetworkRequest
{
	private List<string> backendIds;

	private bool isNew;

	public SetCharactersNewStateRequest(List<Character> characterList, bool isNew)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
