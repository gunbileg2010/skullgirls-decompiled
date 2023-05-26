using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceRewardedVideoEvents : MonoBehaviour
{
	private IUnityLevelPlayRewardedVideo LevelPlayRewardedVideoAndroid;

	private IUnityLevelPlayRewardedVideoManual LevelPlayRewardedVideoAndroidManual;

	public static event Action<IronSourceError, IronSourceAdInfo> onAdShowFailedEvent
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

	public static event Action<IronSourceAdInfo> onAdOpenedEvent
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

	public static event Action<IronSourceAdInfo> onAdClosedEvent
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

	public static event Action<IronSourcePlacement, IronSourceAdInfo> onAdRewardedEvent
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

	public static event Action<IronSourcePlacement, IronSourceAdInfo> onAdClickedEvent
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

	public static event Action<IronSourceAdInfo> onAdAvailableEvent
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

	public static event Action onAdUnavailableEvent
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

	public static event Action<IronSourceError> onAdLoadFailedEvent
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

	public static event Action<IronSourceAdInfo> onAdReadyEvent
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

	private void Awake()
	{
	}

	private void registerRewardedVideoEvents()
	{
	}

	public void registerRewardedVideoManualEvents()
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
}
