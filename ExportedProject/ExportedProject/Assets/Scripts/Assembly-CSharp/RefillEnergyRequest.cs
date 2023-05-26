using System;

public class RefillEnergyRequest : NetworkRequest
{
	private string[] characterIds;

	public RefillEnergyRequest(Character[] characters)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
