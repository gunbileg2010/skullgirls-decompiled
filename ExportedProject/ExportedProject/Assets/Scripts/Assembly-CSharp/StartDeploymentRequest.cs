using System;
using System.Collections.Generic;

public class StartDeploymentRequest : NetworkRequest
{
	private string deploymentBackendId;

	private List<string> fighterBackendIds;

	public StartDeploymentRequest(string deploymentBackendId, List<string> fighterBackendIds)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
