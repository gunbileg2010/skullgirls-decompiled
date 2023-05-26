using System;

public class SetCurrentTeamRequest : NetworkRequest
{
	private string[] characterIds;

	private bool isCompetititve;

	public SetCurrentTeamRequest(Character[] characters, bool isCompetititve = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
