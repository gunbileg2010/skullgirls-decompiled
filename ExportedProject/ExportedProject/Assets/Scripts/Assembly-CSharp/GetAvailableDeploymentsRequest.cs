using System;

public class GetAvailableDeploymentsRequest : NetworkRequest
{
	private bool isDebugClear;

	public GetAvailableDeploymentsRequest(bool isDebugClear = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
