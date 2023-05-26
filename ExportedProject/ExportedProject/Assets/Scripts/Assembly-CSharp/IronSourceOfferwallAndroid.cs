using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceOfferwallAndroid : AndroidJavaProxy, IUnityOfferwall
{
	public event Action<IronSourceError> OnOfferwallShowFailed
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

	public event Action OnOfferwallOpened
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

	public event Action OnOfferwallClosed
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

	public event Action<IronSourceError> OnGetOfferwallCreditsFailed
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

	public event Action<Dictionary<string, object>> OnOfferwallAdCredited
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

	public event Action<bool> OnOfferwallAvailable
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

	public IronSourceOfferwallAndroid()
		: base((string)null)
	{
	}

	public void onOfferwallOpened()
	{
	}

	public void onOfferwallShowFailed(string description)
	{
	}

	public void onOfferwallClosed()
	{
	}

	public void onGetOfferwallCreditsFailed(string description)
	{
	}

	public void onOfferwallAdCredited(string json)
	{
	}

	public void onOfferwallAvailable(string stringAvailable)
	{
	}
}
