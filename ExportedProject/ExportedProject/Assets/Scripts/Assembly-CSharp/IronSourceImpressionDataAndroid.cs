using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceImpressionDataAndroid : AndroidJavaProxy, IUnityImpressionData
{
	public event Action<IronSourceImpressionData> OnImpressionSuccess
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

	public event Action<IronSourceImpressionData> OnImpressionDataReady
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

	public IronSourceImpressionDataAndroid()
		: base((string)null)
	{
	}

	public void onImpressionSuccess(string data)
	{
	}

	public void onImpressionDataReady(string data)
	{
	}
}
