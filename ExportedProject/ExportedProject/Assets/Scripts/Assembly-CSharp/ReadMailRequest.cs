using System;

public class ReadMailRequest : NetworkRequest
{
	private string mailId;

	public ReadMailRequest(string mailId)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
