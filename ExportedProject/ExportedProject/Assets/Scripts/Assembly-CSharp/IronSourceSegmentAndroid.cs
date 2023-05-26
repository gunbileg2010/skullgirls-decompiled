using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IronSourceSegmentAndroid : AndroidJavaProxy, IUnitySegment
{
	public event Action<string> OnSegmentRecieved
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

	public IronSourceSegmentAndroid()
		: base((string)null)
	{
	}

	public void onSegmentRecieved(string segmentName)
	{
	}
}
