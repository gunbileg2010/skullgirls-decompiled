using System;

public class DeleteMailRequest : NetworkRequest
{
	private string mailId;

	public DeleteMailRequest(string mailId)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
