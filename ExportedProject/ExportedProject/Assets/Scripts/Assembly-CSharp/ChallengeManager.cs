using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChallengeManager : MonoBehaviour
{
	[SerializeField]
	private ChallengeData[] challengesDatas;

	[SerializeField]
	private Sprite challengeIcon;

	[SerializeField]
	private Sprite completedChallengeIcon;

	private const int kCheckIntervalMinutes = 10;

	private DateTime nextCheckTime;

	private List<Challenge> cachedChallenges;

	private List<bool> cachedThresholds;

	private DateTime expirationTime;

	private bool newChallengesAvailable;

	private bool refreshingChallenges;

	private int challengeNotifCount;

	private int currentEgretPointCount;

	private int claimableChallengeCount;

	private int claimableChallengeRewardThresholdCount;

	private List<Challenge> updatedChallenges;

	public event Action ChallengesUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<bool> ChallengesRefreshed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public ChallengeData[] GetChallengeDatas()
	{
		return null;
	}

	public ChallengeData GetChallengeDataByGuid(string guid)
	{
		return null;
	}

	public List<Challenge> GetChallenges()
	{
		return null;
	}

	public bool CheckIfThresholdClaimed(int thresholdIndex)
	{
		return false;
	}

	public void MarkChallengesSeen()
	{
	}

	public void InvalidateCachedData()
	{
	}

	public void RefreshChallenges(Action<bool> callback = null, bool forceUpdate = false)
	{
	}

	public void ClaimChallenge(string challengeGuid, Action<bool> callback = null)
	{
	}

	public void ClaimAllChallengesAndThresholds(Action<bool, bool> callback = null)
	{
	}

	public void ClaimChallengesRewards(ChallengeRewardThresholdUI challengeRewardsThreshold, Action<bool> callback = null)
	{
	}

	public void RefreshChallengeNotifCount()
	{
	}

	public void ResetChallengeNotifCounts()
	{
	}

	public bool AreNewChallengesAvailable()
	{
		return false;
	}

	public bool IsAtOrBeyondMaxCompletion()
	{
		return false;
	}

	public bool DoChallengesNeedRefresh()
	{
		return false;
	}

	public int GetClaimableChallengeRewardThresholdsCount()
	{
		return 0;
	}

	public int GetThresholdInterval()
	{
		return 0;
	}

	public int GetChallengeRewardThresholdCount()
	{
		return 0;
	}

	public int GetChallengeNotifCount()
	{
		return 0;
	}

	public int GetCurrentEgretPointCount()
	{
		return 0;
	}

	public DateTime GetExpirationTime()
	{
		return default(DateTime);
	}

	public List<Challenge> GetUpdatedChallenges()
	{
		return null;
	}

	public static bool IsFightRelatedChallenge(ChallengeType type)
	{
		return false;
	}

	public bool IsDirectPurchaseStoreChallengeCompleteOrNull()
	{
		return false;
	}

	private void ApplyChallengeUpdates()
	{
	}

	private Challenge GetChallengeFromChallengeGuid(string challengeGuid)
	{
		return null;
	}

	private void ShowToastForChallenge(Challenge challenge)
	{
	}

	private void RecalculateClaimableChallengeRewardThresholdCount()
	{
	}

	private void OnLogin(AuthenticateRequest authRequest)
	{
	}

	private void OnResponseDictionaryReceived(Dictionary<string, object> responseDictionary)
	{
	}
}
