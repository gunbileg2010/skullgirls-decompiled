using System;

public interface IUnityInterstitial
{
	event Action<IronSourceError> OnInterstitialAdShowFailed;

	event Action<IronSourceError> OnInterstitialAdLoadFailed;

	event Action OnInterstitialAdReady;

	event Action OnInterstitialAdOpened;

	event Action OnInterstitialAdClosed;

	event Action OnInterstitialAdShowSucceeded;

	event Action OnInterstitialAdClicked;

	event Action OnInterstitialAdRewarded;

	event Action<string> OnInterstitialAdReadyDemandOnly;

	event Action<string> OnInterstitialAdOpenedDemandOnly;

	event Action<string> OnInterstitialAdClosedDemandOnly;

	event Action<string, IronSourceError> OnInterstitialAdLoadFailedDemandOnly;

	event Action<string> OnInterstitialAdClickedDemandOnly;

	event Action<string, IronSourceError> OnInterstitialAdShowFailedDemandOnly;
}
