using System;

public class ForgotPasswordRequest : NetworkRequest
{
	private string email;

	public ForgotPasswordRequest(string email)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
