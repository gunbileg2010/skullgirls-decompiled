using System;
using System.Collections.Generic;

public class FriendInstance
{
	public enum FriendStatus
	{
		Friends = 0,
		SentRequest = 1,
		ReceivedRequest = 2,
		NoRelation = 3
	}

	public Action OnlineStatusCheckFinish;

	private string friendPublicId;

	private FriendStatus friendshipStatus;

	private XsProfile friendProfile;

	private long outgoingGiftDailyResetTimestamp;

	private long outgoingGiftOpeningTimestamp;

	private CurrencyType incomingSocialGiftType;

	private long incomingGiftReceivedTimestamp;

	private string onlineDisplayText;

	private DateTime lastActivityDate;

	private Dictionary<CurrencyType, int> giftsSent;

	private Dictionary<CurrencyType, int> giftsReceived;

	private bool wasUpdated;

	private long friendshipCreationDate;

	private int adjustedGoldGiftsSent;

	private int adjustedGoldGiftsClaimed;

	private int adjustedStandardGiftsSent;

	private int adjustedStandardGiftsClaimed;

	public FriendInstance()
	{
	}

	public FriendInstance(Dictionary<string, object> data)
	{
	}

	public FriendInstance(XsProfile profile)
	{
	}

	public void ParseServerData(Dictionary<string, object> data)
	{
	}

	public string GetFriendPublicId()
	{
		return null;
	}

	public string GetPublicId()
	{
		return null;
	}

	public FriendStatus GetFriendshipStatus()
	{
		return default(FriendStatus);
	}

	public void SetFriendshipStatus(FriendStatus friendshipStatus)
	{
	}

	public XsProfile GetXsProfile()
	{
		return null;
	}

	public long GetOutgoingGiftDailyResetTimestamp()
	{
		return 0L;
	}

	public void SetOutgoingGiftDailyResetTimestamp(long outgoingGiftDailyResetTimestamp)
	{
	}

	public long GetOutgoingGiftOpeningTimestamp()
	{
		return 0L;
	}

	public void ResetOutgoingGiftOpeningTimestamp()
	{
	}

	public CurrencyType GetIncomingSocialGiftType()
	{
		return default(CurrencyType);
	}

	public long GetIncomingGiftReceivedTimestamp()
	{
		return 0L;
	}

	public string GetOnlineDisplayText()
	{
		return null;
	}

	public void SetOnlineDisplayText(string onlineDisplayText)
	{
	}

	public void SetAdjustedGiftsSent(bool isGold, int count)
	{
	}

	public void SetAdjustedGiftsClaimed(bool isGold, int count)
	{
	}

	public int GetSentGiftsCount(bool isGold)
	{
		return 0;
	}

	public int GetReceivedGiftsCount(bool isGold)
	{
		return 0;
	}

	public bool GetWasUpdated()
	{
		return false;
	}

	public void SetWasUpdated(bool wasUpdated)
	{
	}

	public long GetFriendshipCreationDate()
	{
		return 0L;
	}

	public void ResetIncomingGiftReceivedTimestamp()
	{
	}

	public FriendStatus ParseFriendStatus(string value)
	{
		return default(FriendStatus);
	}
}
