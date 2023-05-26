using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceInterstitialAndroid : AndroidJavaProxy, IUnityInterstitial
{
	public event Action<IronSourceError> OnInterstitialAdShowFailed
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

	public event Action<IronSourceError> OnInterstitialAdLoadFailed
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

	public event Action OnInterstitialAdReady
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

	public event Action OnInterstitialAdOpened
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

	public event Action OnInterstitialAdClosed
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

	public event Action OnInterstitialAdShowSucceeded
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

	public event Action OnInterstitialAdClicked
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

	public event Action OnInterstitialAdRewarded
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

	public event Action<string> OnInterstitialAdReadyDemandOnly
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

	public event Action<string> OnInterstitialAdOpenedDemandOnly
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

	public event Action<string> OnInterstitialAdClosedDemandOnly
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

	public event Action<string, IronSourceError> OnInterstitialAdLoadFailedDemandOnly
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

	public event Action<string> OnInterstitialAdClickedDemandOnly
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

	public event Action<string, IronSourceError> OnInterstitialAdShowFailedDemandOnly
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

	public IronSourceInterstitialAndroid()
		: base((string)null)
	{
	}

	private void onInterstitialAdShowFailed(string description)
	{
	}

	private void onInterstitialAdReady()
	{
	}

	private void onInterstitialAdOpened()
	{
	}

	private void onInterstitialAdClosed()
	{
	}

	private void onInterstitialAdShowSucceeded()
	{
	}

	private void onInterstitialAdClicked()
	{
	}

	private void onInterstitialAdLoadFailed(string args)
	{
	}

	private void onInterstitialAdRewarded()
	{
	}

	private void onInterstitialAdClickedDemandOnly(string instanceId)
	{
	}

	private void onInterstitialAdClosedDemandOnly(string instanceId)
	{
	}

	private void onInterstitialAdOpenedDemandOnly(string instanceId)
	{
	}

	private void onInterstitialAdReadyDemandOnly(string instanceId)
	{
	}

	private void onInterstitialAdLoadFailedDemandOnly(string args)
	{
	}

	private void onInterstitialAdShowFailedDemandOnly(string args)
	{
	}
}
