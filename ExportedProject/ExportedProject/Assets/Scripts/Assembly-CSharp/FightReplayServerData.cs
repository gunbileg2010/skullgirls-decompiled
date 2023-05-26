using System;
using System.Collections.Generic;

public class FightReplayServerData
{
	public string id;

	public string publicReplayId;

	public string userId;

	public XsProfile playerUser;

	public List<Character> playerTeam;

	public XsProfile opponentUser;

	public List<Character> opponentTeam;

	public string fightId;

	public GameType gameType;

	public string actGuid;

	public string chapterGuid;

	public string matchGuid;

	public string eventGuid;

	public byte[] replay;

	public List<XsCharacter> xsPlayerTeam;

	public List<XsCharacter> xsOpponentTeam;

	private Dictionary<string, object> dataDict;

	public FightReplayServerData(Dictionary<string, object> dataDict)
	{
	}

	private void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public DateTime GetTimestampDateTime()
	{
		return default(DateTime);
	}

	public Dictionary<string, object> GetMetaDataForChatActivity()
	{
		return null;
	}
}
