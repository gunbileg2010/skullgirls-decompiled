using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceBannerLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayBanner
{
	public event Action<IronSourceAdInfo> OnAdLoaded
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

	public event Action<IronSourceAdInfo> OnAdLeftApplication
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

	public event Action<IronSourceAdInfo> OnAdScreenDismissed
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

	public event Action<IronSourceAdInfo> OnAdScreenPresented
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

	public IronSourceBannerLevelPlayAndroid()
		: base((string)null)
	{
	}

	private void onAdLoaded(string data)
	{
	}

	private void onAdLoadFailed(string args)
	{
	}

	private void onAdClicked(string data)
	{
	}

	private void onAdScreenPresented(string data)
	{
	}

	private void onAdScreenDismissed(string data)
	{
	}

	private void onAdLeftApplication(string data)
	{
	}
}
