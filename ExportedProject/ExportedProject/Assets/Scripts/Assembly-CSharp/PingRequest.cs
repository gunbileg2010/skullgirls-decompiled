using System;

public class PingRequest : NetworkRequest
{
	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
