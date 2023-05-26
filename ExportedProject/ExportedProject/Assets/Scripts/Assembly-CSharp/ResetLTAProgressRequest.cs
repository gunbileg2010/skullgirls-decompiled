using System;

public class ResetLTAProgressRequest : NetworkRequest
{
	private string eventInstanceId;

	public ResetLTAProgressRequest(string eventInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
