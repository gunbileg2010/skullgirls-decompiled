using System.Collections.Generic;
using UnityEngine;

public class IronSourceConfig
{
	private const string unsupportedPlatformStr = "Unsupported Platform";

	private static IronSourceConfig _instance;

	private static AndroidJavaObject _androidBridge;

	private static readonly string AndroidBridge;

	public static IronSourceConfig Instance => null;

	public void setLanguage(string language)
	{
	}

	public void setClientSideCallbacks(bool status)
	{
	}

	public void setRewardedVideoCustomParams(Dictionary<string, string> rewardedVideoCustomParams)
	{
	}

	public void setOfferwallCustomParams(Dictionary<string, string> offerwallCustomParams)
	{
	}
}
