using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceInterstitialLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayInterstitial
{
	public event Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed
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

	public event Action<IronSourceError> OnAdLoadFailed
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

	public event Action<IronSourceAdInfo> OnAdReady
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

	public event Action<IronSourceAdInfo> OnAdOpened
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

	public event Action<IronSourceAdInfo> OnAdClosed
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

	public event Action<IronSourceAdInfo> OnAdShowSucceeded
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

	public event Action<IronSourceAdInfo> OnAdClicked
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

	public IronSourceInterstitialLevelPlayAndroid()
		: base((string)null)
	{
	}

	private void onAdShowFailed(string description, string data)
	{
	}

	private void onAdReady(string data)
	{
	}

	private void onAdOpened(string data)
	{
	}

	private void onAdClosed(string data)
	{
	}

	private void onAdShowSucceeded(string data)
	{
	}

	private void onAdClicked(string data)
	{
	}

	private void onAdLoadFailed(string args)
	{
	}
}
