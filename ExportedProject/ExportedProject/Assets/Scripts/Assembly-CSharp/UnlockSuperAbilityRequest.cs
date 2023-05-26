using System;

public class UnlockSuperAbilityRequest : NetworkRequest
{
	private string characterBackendId;

	private int featureSetIndex;

	public UnlockSuperAbilityRequest(string characterBackendId, int selectedFeatureSet)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
