using System;
using System.Collections.Generic;

public class SetEventMapNodeDataRequest : NetworkRequest
{
	private string eventGuid;

	private int nodeIndex;

	private List<string> characterIds;

	private List<string> modifierIds;

	public SetEventMapNodeDataRequest(string eventGuid, int nodeIndex, List<string> characterIds, List<string> modifierIds)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
