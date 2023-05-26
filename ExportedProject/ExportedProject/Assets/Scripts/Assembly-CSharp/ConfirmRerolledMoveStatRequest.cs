using System;

public class ConfirmRerolledMoveStatRequest : NetworkRequest
{
	private string moveId;

	private bool accept;

	public ConfirmRerolledMoveStatRequest(string moveId, bool accept)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
