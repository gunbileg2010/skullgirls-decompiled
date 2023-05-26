using System;

public class EndFightRequest : NetworkRequest
{
	private string fightId;

	private WinState winState;

	private FightStats fightStats;

	private string replayString;

	private FightResultServerData fightResultData;

	public EndFightRequest(string fightId, WinState winState, FightStats fightStats = null, string replayString = null)
	{
	}

	public override void Send(Action callback)
	{
	}

	public FightResultServerData GetFightResultData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
