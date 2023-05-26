using System;

public class RerollSingleGearStatRequest : NetworkRequest
{
	private string moveId;

	private string statGuid;

	private string newStatGuid;

	public RerollSingleGearStatRequest(string moveId, string statGuid)
	{
	}

	public override void Send(Action callback)
	{
	}

	public string GetNewMoveStatGuid()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
