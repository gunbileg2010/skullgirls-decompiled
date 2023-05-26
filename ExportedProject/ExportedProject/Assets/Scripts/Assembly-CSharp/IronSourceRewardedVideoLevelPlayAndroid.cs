using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceRewardedVideoLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayRewardedVideo
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

	public event Action<IronSourcePlacement, IronSourceAdInfo> OnAdRewarded
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

	public event Action<IronSourcePlacement, IronSourceAdInfo> OnAdClicked
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

	public event Action<IronSourceAdInfo> OnAdAvailable
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

	public event Action OnAdUnavailable
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

	public IronSourceRewardedVideoLevelPlayAndroid()
		: base((string)null)
	{
	}

	private void onAdShowFailed(string description, string data)
	{
	}

	private void onAdClosed(string data)
	{
	}

	private void onAdOpened(string data)
	{
	}

	private void onAdRewarded(string description, string data)
	{
	}

	private void onAdClicked(string description, string data)
	{
	}

	private void onAdAvailable(string data)
	{
	}

	private void onAdUnavailable()
	{
	}
}
