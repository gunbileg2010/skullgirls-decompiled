using System;

public class FlagAccountForDeletionRequest : NetworkRequest
{
	private bool removeFlags;

	public FlagAccountForDeletionRequest(bool removeFlags = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
