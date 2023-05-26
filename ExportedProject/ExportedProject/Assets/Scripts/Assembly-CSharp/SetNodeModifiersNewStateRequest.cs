using System;
using System.Collections.Generic;

public class SetNodeModifiersNewStateRequest : NetworkRequest
{
	private List<string> backendIds;

	private bool isNew;

	public SetNodeModifiersNewStateRequest(List<CollectibleNodeModifier> nodeModifierList, bool isNew)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
