using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoSingleton<AdManager>
{
	public Action<DateTime> UpdateAdButton;

	public Action ClaimedPopupClosed;

	public Action AdClosed;

	[SerializeField]
	private float timeBetweenClaimRequests;

	[SerializeField]
	private int claimRequestAttempts;

	[SerializeField]
	private List<AdReward> adRewards;

	private const string kAppKeyRelease_AOS = "b6fbb25d";

	private const string kAppKeyRelease_IOS = "b6fb78d5";

	private const string kAppKeyQA_AOS = "b6fc256d";

	private const string kAppKeyQA_IOS = "b6fbebe5";

	private const string kAppKeySTAGING_AOS = "ca8a438d";

	private const string kAppKeySTAGING_IOS = "ca8c0fcd";

	private const string kAppKeyDEV_AOS = "b6fa1fa5";

	private const string kAppKeyDEV_IOS = "b6f9e61d";

	private const string kPlacementName = "DefaultRewardedVideo";

	private DateTime? cachedAdPacingExpiration;

	private string cachedAdRewardGuid;

	private bool areAdsInitialized;

	private bool rewardedVideoAvailable;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationPause(bool isPaused)
	{
	}

	public void PlayRewardedVideo()
	{
	}

	public DateTime GetCachedAdPacingExpiration()
	{
		return default(DateTime);
	}

	public bool IsPlacementCurrentlyCapped()
	{
		return false;
	}

	public bool IsAdAvailable()
	{
		return false;
	}

	public AdReward GetCurrentAdRewardForPlacement(string placementName = "DefaultRewardedVideo")
	{
		return null;
	}

	public AdReward GetAdRewardByGuid(string guid)
	{
		return null;
	}

	public void CheckForUnclaimedAds()
	{
	}

	public bool AreAdsInitialized()
	{
		return false;
	}

	private bool IsActiveOnPlatform()
	{
		return false;
	}

	private void OnLogin(AuthenticateRequest authenticateRequest)
	{
	}

	private void InitializeAds()
	{
	}

	private void RewardedVideoAdOpenedEvent()
	{
	}

	private void RewardedVideoAdClosedEvent()
	{
	}

	private void RewardedVideoAvailabilityChangedEvent(bool available)
	{
	}

	private void RewardedVideoAdShowFailedEvent(IronSourceError error)
	{
	}

	private IEnumerator CheckForRewards()
	{
		return null;
	}

	public AdManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
