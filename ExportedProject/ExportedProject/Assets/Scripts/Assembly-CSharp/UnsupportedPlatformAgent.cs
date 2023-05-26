using System.Collections.Generic;

public class UnsupportedPlatformAgent : IronSourceIAgent
{
	public void start()
	{
	}

	public void onApplicationPause(bool pause)
	{
	}

	public void setMediationSegment(string segment)
	{
	}

	public string getAdvertiserId()
	{
		return null;
	}

	public void validateIntegration()
	{
	}

	public void shouldTrackNetworkState(bool track)
	{
	}

	public bool setDynamicUserId(string dynamicUserId)
	{
		return false;
	}

	public void setAdaptersDebug(bool enabled)
	{
	}

	public void setMetaData(string key, string value)
	{
	}

	public void setMetaData(string key, params string[] values)
	{
	}

	public int? getConversionValue()
	{
		return null;
	}

	public void setManualLoadRewardedVideo(bool isOn)
	{
	}

	public void setNetworkData(string networkKey, string networkDataJson)
	{
	}

	public void SetPauseGame(bool pause)
	{
	}

	public void setUserId(string userId)
	{
	}

	public void init(string appKey)
	{
	}

	public void init(string appKey, params string[] adUnits)
	{
	}

	public void initISDemandOnly(string appKey, params string[] adUnits)
	{
	}

	public void loadRewardedVideo()
	{
	}

	public void showRewardedVideo()
	{
	}

	public void showRewardedVideo(string placementName)
	{
	}

	public bool isRewardedVideoAvailable()
	{
		return false;
	}

	public bool isRewardedVideoPlacementCapped(string placementName)
	{
		return false;
	}

	public IronSourcePlacement getPlacementInfo(string placementName)
	{
		return null;
	}

	public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
	{
	}

	public void clearRewardedVideoServerParams()
	{
	}

	public void showISDemandOnlyRewardedVideo(string instanceId)
	{
	}

	public void loadISDemandOnlyRewardedVideo(string instanceId)
	{
	}

	public bool isISDemandOnlyRewardedVideoAvailable(string instanceId)
	{
		return false;
	}

	public void loadInterstitial()
	{
	}

	public void showInterstitial()
	{
	}

	public void showInterstitial(string placementName)
	{
	}

	public bool isInterstitialReady()
	{
		return false;
	}

	public bool isInterstitialPlacementCapped(string placementName)
	{
		return false;
	}

	public void loadISDemandOnlyInterstitial(string instanceId)
	{
	}

	public void showISDemandOnlyInterstitial(string instanceId)
	{
	}

	public bool isISDemandOnlyInterstitialReady(string instanceId)
	{
		return false;
	}

	public void showOfferwall()
	{
	}

	public void showOfferwall(string placementName)
	{
	}

	public void getOfferwallCredits()
	{
	}

	public bool isOfferwallAvailable()
	{
		return false;
	}

	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
	{
	}

	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
	{
	}

	public void destroyBanner()
	{
	}

	public void displayBanner()
	{
	}

	public void hideBanner()
	{
	}

	public bool isBannerPlacementCapped(string placementName)
	{
		return false;
	}

	public void setSegment(IronSourceSegment segment)
	{
	}

	public void setConsent(bool consent)
	{
	}

	public void loadConsentViewWithType(string consentViewType)
	{
	}

	public void showConsentViewWithType(string consentViewType)
	{
	}

	public void setAdRevenueData(string dataSource, Dictionary<string, string> impressionData)
	{
	}
}
