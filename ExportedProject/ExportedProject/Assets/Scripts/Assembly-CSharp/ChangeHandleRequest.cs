using System;

public class ChangeHandleRequest : NetworkRequest
{
	private string handle;

	private bool needToPayForChange;

	public ChangeHandleRequest(string handle, bool needToPayForChange)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
