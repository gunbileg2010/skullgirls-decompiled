using System;

public class ChangeEmailRequest : NetworkRequest
{
	private string email;

	private string password;

	public ChangeEmailRequest(string email, string password)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
