using System;

public class RefreshDeploymentRequest : NetworkRequest
{
	private string deploymentBackendId;

	public RefreshDeploymentRequest(string deploymentBackendId)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
