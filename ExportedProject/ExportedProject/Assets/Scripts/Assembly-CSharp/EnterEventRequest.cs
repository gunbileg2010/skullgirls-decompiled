using System;

public class EnterEventRequest : NetworkRequest
{
	private string eventInstanceId;

	public EnterEventRequest(string eventInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
