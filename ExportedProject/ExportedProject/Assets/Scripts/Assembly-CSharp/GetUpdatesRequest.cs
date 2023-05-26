using System;

public class GetUpdatesRequest : NetworkRequest
{
	private int numberOfSocialUpdates;

	private int numberOfRiftBattleUpdates;

	public override void Send(Action callback)
	{
	}

	public int GetNumberOfSocialUpdates()
	{
		return 0;
	}

	public int GetNumberOfRiftBattleUpdates()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
