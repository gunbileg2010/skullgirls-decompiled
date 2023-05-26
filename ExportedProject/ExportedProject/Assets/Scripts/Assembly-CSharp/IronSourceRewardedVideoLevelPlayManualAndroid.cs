using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceRewardedVideoLevelPlayManualAndroid : AndroidJavaProxy, IUnityLevelPlayRewardedVideoManual
{
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

	public IronSourceRewardedVideoLevelPlayManualAndroid()
		: base((string)null)
	{
	}

	private void onAdReady(string data)
	{
	}

	private void onAdLoadFailed(string args)
	{
	}
}
