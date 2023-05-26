using System;
using System.Collections.Generic;

public class PrepFightRequest : NetworkRequest
{
	private GameType fightType;

	private string actGuid;

	private string chapterGuid;

	private string matchGuid;

	private string eventId;

	private string opponentId;

	private bool isLineId;

	private string opponentPublicId;

	private bool isPrivateMatch;

	private List<FightInstanceServerData> fightInstanceServerDatas;

	private EventResultsServerData eventResults;

	public PrepFightRequest(string actGuid, string chapterGuid, string matchGuid)
	{
	}

	public PrepFightRequest(string actGuid, string chapterGuid, string matchGuid, string eventId, GameType fightType = GameType.LimitedTimeAct)
	{
	}

	public PrepFightRequest(string eventId, GameType fightType)
	{
	}

	public PrepFightRequest(string opponentId, bool isLineId)
	{
	}

	public PrepFightRequest(string eventId, string opponentPublicId, bool isPrivateMatch)
	{
	}

	public override void Send(Action callback)
	{
	}

	public FightInstanceServerData GetFightInstance()
	{
		return null;
	}

	public List<FightInstanceServerData> GetFightInstances()
	{
		return null;
	}

	public EventResultsServerData GetEventResults()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
