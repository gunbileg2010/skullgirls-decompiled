using System;

public class UpgradeSuperAbilityRequest : NetworkRequest
{
	private string characterBackendId;

	private int featureSetIndex;

	public UpgradeSuperAbilityRequest(string characterBackendId, int featureSetIndex)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
