using System;

public class ConsumeConsumableRequest : NetworkRequest
{
	protected string consumableGuid;

	private bool grantXPBoostTutorialRewards;

	public ConsumeConsumableRequest(string consumableGuid, bool grantXPBoostTutorialRewards = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
