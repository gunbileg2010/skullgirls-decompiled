using System;
using System.Collections.Generic;
using UnityEngine;

public class MailServerData
{
	public const string kChallengeMailType = "DailyChallengeSingle";

	public const string kEventResultMailTypeOLD = "EventResult";

	public const string kEventNoRewardsMailTypeOLD = "EventNoRewards";

	public const string kPrizeFightResultMailType = "PrizeFightResult";

	public const string kPrizeFightNoRewardsScoreMailType = "PrizeFightNoRewardsScore";

	public const string kPrizeFightNoRewardsRankMailType = "PrizeFightNoRewardsRank";

	public const string kRiftBattleSeasonResultMailType = "RiftBattleSeasonResult";

	public const string kRiftBattleIndividualResultMailType = "RiftBattleIndividualResult";

	public const string kRiftBattleNoRewardsMailType = "RiftBattleNoRewards";

	public const string kStoreInternalRedirectType = "Store";

	public const string kEventsInternalRedirectType = "Events";

	public const string kPrizeFightInternalRedirectType = "PrizeFights";

	public const string kMissionControlInternalRedirectType = "MissionControl";

	public const string kCollectionInternalRedirectType = "Collection";

	public const string kCollectionCharactersInternalRedirectType = "CollectionCharacters";

	public const string kCollectionMovesInternalRedirectType = "CollectionMoves";

	public const string kRelicStoreInternalRedirectType = "RelicStore";

	public string backendId;

	public DateTime sendDateTime;

	public string mailType;

	public Dictionary<string, string> metadata;

	public bool unread;

	public bool claimed;

	public List<Loot> claimableLoot;

	public bool wasDeleted;

	private static MailFormatter defaultFormatter;

	private MailFormatter formatter;

	private string subject;

	private string body;

	private string banner;

	private Texture2D bannerTexture;

	private string externalUrl;

	private string internalRedirect;

	public MailServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public bool HasUnclaimedLoot()
	{
		return false;
	}

	public string GetSubject()
	{
		return null;
	}

	public string GetBody()
	{
		return null;
	}

	public string GetHumanReadableGuid()
	{
		return null;
	}

	public MailFormatter GetFormatter()
	{
		return null;
	}

	public Texture2D GetBanner()
	{
		return null;
	}

	public bool HasRedirect()
	{
		return false;
	}

	public string GetExternalUrl()
	{
		return null;
	}

	public string GetInternalRedirect()
	{
		return null;
	}
}
