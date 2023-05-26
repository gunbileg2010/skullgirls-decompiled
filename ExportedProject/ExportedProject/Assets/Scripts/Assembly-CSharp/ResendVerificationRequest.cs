using System;

public class ResendVerificationRequest : NetworkRequest
{
	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
