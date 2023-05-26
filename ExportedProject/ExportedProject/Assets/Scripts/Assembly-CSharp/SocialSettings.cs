using System.Collections.Generic;
using UnityEngine;

public class SocialSettings : ScriptableObject, IServerUploadable
{
	[SerializeField]
	private int maximumFriendCount;

	[SerializeField]
	private int maximumClaimedSocialGifts;

	[SerializeField]
	private int searchUsersReturnCount;

	[SerializeField]
	private GachaData.WeightedLootTableSet[] lootsPerSocialGift;

	public int GetMaximumFriendCount()
	{
		return 0;
	}

	public void SetMaximumFriendCount(int maximumFriendCount)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
