using System;

public class ClaimDeploymentRequest : NetworkRequest
{
	private string deploymentBackendId;

	private long completionTimestamp;

	private bool hurryUp;

	public ClaimDeploymentRequest(DeploymentServerData deployment, bool hurryUp)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
