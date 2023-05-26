using System;

public class SwapSuperAbilityRequest : NetworkRequest
{
	private string characterBackendId;

	private int newFeatureSet;

	public SwapSuperAbilityRequest(string characterBackendId, int newFeatureSet)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
