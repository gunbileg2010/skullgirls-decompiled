using System.Collections.Generic;

public static class FriendManager
{
	private static Dictionary<string, Friend> facebookFriends;

	private static Dictionary<string, Friend> gameCenterFriends;

	private static Dictionary<string, Friend> googlePlusFriends;

	public static Friend GetFacebookFriend(string fbid)
	{
		return null;
	}

	public static bool DeleteFacebookFriend(string fbid)
	{
		return false;
	}

	public static void DeleteAllFacebookFriends()
	{
	}

	public static Friend GetGameCenterFriend(string gcid)
	{
		return null;
	}

	public static bool DeleteGameCenterFriend(string gcid)
	{
		return false;
	}

	public static void DeleteAllGameCenterFriends()
	{
	}

	public static Friend GetGooglePlusFriend(string gpId)
	{
		return null;
	}

	public static bool DeleteGooglePlusFriend(string gpId)
	{
		return false;
	}

	public static void DeleteAllGooglePlusFriends()
	{
	}
}
