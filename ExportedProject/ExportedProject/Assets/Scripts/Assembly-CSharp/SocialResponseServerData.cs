using System.Collections.Generic;

public class SocialResponseServerData
{
	public enum ResponseState
	{
		Successful = 0,
		ToSelf = 1,
		AlreadyExists = 2,
		MaximumFriendsExceeded = 3,
		InstanceCountsDontMatch = 4,
		IncorrectFriendStatus = 5,
		CantSendYet = 6,
		NoneAvailable = 7,
		MaximumClaimedGiftsExceeded = 8,
		TooManyFriendsRemoved = 9,
		NullDict = 10
	}

	private ResponseState state;

	private List<string> impactedUserIds;

	public SocialResponseServerData(Dictionary<string, object> dataDict)
	{
	}

	public ResponseState GetResponseState()
	{
		return default(ResponseState);
	}

	public List<string> GetImpactedUserIds()
	{
		return null;
	}

	private ResponseState ParseFromString(string value)
	{
		return default(ResponseState);
	}
}
