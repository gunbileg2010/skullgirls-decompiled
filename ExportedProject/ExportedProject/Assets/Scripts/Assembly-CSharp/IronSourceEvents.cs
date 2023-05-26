using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceEvents : MonoBehaviour
{
	private const string ERROR_CODE = "error_code";

	private const string ERROR_DESCRIPTION = "error_description";

	private const string INSTANCE_ID_KEY = "instanceId";

	private const string PLACEMENT_KEY = "placement";

	private IUnityInitialization initializationAndroid;

	private IUnityRewardedVideo rewardedVideoAndroid;

	private IUnityRewardedVideoManual rewardedVideoAndroidManual;

	private IUnityInterstitial interstitialAndroid;

	private IUnityOfferwall offerwallAndroid;

	private IUnityBanner bannerAndroid;

	private IUnitySegment segmentAndroid;

	private IUnityImpressionData impressionDataAndroid;

	public static event Action onSdkInitializationCompletedEvent
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

	public static event Action<IronSourceError> onRewardedVideoAdShowFailedEvent
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

	public static event Action onRewardedVideoAdOpenedEvent
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

	public static event Action onRewardedVideoAdClosedEvent
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

	public static event Action onRewardedVideoAdStartedEvent
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

	public static event Action onRewardedVideoAdEndedEvent
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

	public static event Action<IronSourcePlacement> onRewardedVideoAdRewardedEvent
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

	public static event Action<IronSourcePlacement> onRewardedVideoAdClickedEvent
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

	public static event Action<bool> onRewardedVideoAvailabilityChangedEvent
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

	public static event Action<IronSourceError> onRewardedVideoAdLoadFailedEvent
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

	public static event Action onRewardedVideoAdReadyEvent
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

	public static event Action<string> onRewardedVideoAdOpenedDemandOnlyEvent
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

	public static event Action<string> onRewardedVideoAdClosedDemandOnlyEvent
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

	public static event Action<string> onRewardedVideoAdLoadedDemandOnlyEvent
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

	public static event Action<string> onRewardedVideoAdRewardedDemandOnlyEvent
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

	public static event Action<string, IronSourceError> onRewardedVideoAdShowFailedDemandOnlyEvent
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

	public static event Action<string> onRewardedVideoAdClickedDemandOnlyEvent
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

	public static event Action<string, IronSourceError> onRewardedVideoAdLoadFailedDemandOnlyEvent
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

	public static event Action onInterstitialAdReadyEvent
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

	public static event Action<IronSourceError> onInterstitialAdLoadFailedEvent
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

	public static event Action onInterstitialAdOpenedEvent
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

	public static event Action onInterstitialAdClosedEvent
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

	public static event Action onInterstitialAdShowSucceededEvent
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

	public static event Action<IronSourceError> onInterstitialAdShowFailedEvent
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

	public static event Action onInterstitialAdClickedEvent
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

	public static event Action<string> onInterstitialAdReadyDemandOnlyEvent
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

	public static event Action<string> onInterstitialAdOpenedDemandOnlyEvent
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

	public static event Action<string> onInterstitialAdClosedDemandOnlyEvent
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

	public static event Action<string, IronSourceError> onInterstitialAdLoadFailedDemandOnlyEvent
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

	public static event Action<string> onInterstitialAdClickedDemandOnlyEvent
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

	public static event Action<string, IronSourceError> onInterstitialAdShowFailedDemandOnlyEvent
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

	public static event Action<bool> onOfferwallAvailableEvent
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

	public static event Action onOfferwallOpenedEvent
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

	public static event Action<Dictionary<string, object>> onOfferwallAdCreditedEvent
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

	public static event Action<IronSourceError> onGetOfferwallCreditsFailedEvent
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

	public static event Action onOfferwallClosedEvent
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

	public static event Action<IronSourceError> onOfferwallShowFailedEvent
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

	public static event Action onBannerAdLoadedEvent
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

	public static event Action onBannerAdLeftApplicationEvent
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

	public static event Action onBannerAdScreenDismissedEvent
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

	public static event Action onBannerAdScreenPresentedEvent
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

	public static event Action onBannerAdClickedEvent
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

	public static event Action<IronSourceError> onBannerAdLoadFailedEvent
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

	public static event Action<string> onSegmentReceivedEvent
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

	public static event Action<IronSourceImpressionData> onImpressionSuccessEvent
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

	public static event Action<IronSourceImpressionData> onImpressionDataReadyEvent
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

	private static event Action<string, IronSourceError> _onConsentViewDidFailToLoadWithErrorEvent
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

	public static event Action<string, IronSourceError> onConsentViewDidFailToLoadWithErrorEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string, IronSourceError> _onConsentViewDidFailToShowWithErrorEvent
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

	public static event Action<string, IronSourceError> onConsentViewDidFailToShowWithErrorEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidAcceptEvent
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

	public static event Action<string> onConsentViewDidAcceptEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidDismissEvent
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

	public static event Action<string> onConsentViewDidDismissEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidLoadSuccessEvent
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

	public static event Action<string> onConsentViewDidLoadSuccessEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private static event Action<string> _onConsentViewDidShowSuccessEvent
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

	public static event Action<string> onConsentViewDidShowSuccessEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void registerInitializationEvents()
	{
	}

	private void registerBannerEvents()
	{
	}

	private void registerInterstitialEvents()
	{
	}

	private void registerInterstitialDemandOnlyEvents()
	{
	}

	private void registerOfferwallEvents()
	{
	}

	private void registerSegmentEvents()
	{
	}

	private void registerImpressionDataEvents()
	{
	}

	public void registerRewardedVideoDemandOnlyEvents()
	{
	}

	private void registerRewardedVideoEvents()
	{
	}

	public void registerRewardedVideoManualEvents()
	{
	}

	public void onConsentViewDidFailToLoadWithError(string args)
	{
	}

	public void onConsentViewDidFailToShowWithError(string args)
	{
	}

	public void onConsentViewDidAccept(string consentViewType)
	{
	}

	public void onConsentViewDidDismiss(string consentViewType)
	{
	}

	public void onConsentViewDidLoadSuccess(string consentViewType)
	{
	}

	public void onConsentViewDidShowSuccess(string consentViewType)
	{
	}

	private IronSourceError getErrorFromErrorObject(object descriptionObject)
	{
		return null;
	}

	private IronSourcePlacement getPlacementFromObject(object placementObject)
	{
		return null;
	}

	private static void InvokeEvent(Action<IronSourceImpressionData> evt, string args)
	{
	}
}
