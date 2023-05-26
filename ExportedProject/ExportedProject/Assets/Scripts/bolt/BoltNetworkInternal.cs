using System;
using System.Collections.Generic;
using System.Reflection;
using Bolt;
using BoltInternal;
using UdpKit;

[Documentation]
public class BoltNetworkInternal
{
	public static bool UsingUnityPro;

	public static Action EnvironmentSetup;

	public static Action EnvironmentReset;

	public static IDebugDrawer DebugDrawer;

	public static Func<int, string> GetSceneName;

	public static Func<string, int> GetSceneIndex;

	public static Func<List<STuple<BoltGlobalBehaviourAttribute, Type>>> GetGlobalBehaviourTypes;

	public static UdpPlatform DefaultPlatform => null;

	public static bool Setup()
	{
		return false;
	}

	public static void Initialize(BoltNetworkModes mode, UdpEndPoint endpoint, BoltConfig config, UdpPlatform platform = null, string autoloadScene = null)
	{
	}

	[Obsolete]
	public static void Shutdown()
	{
	}

	private static Assembly GetAssemblyByName(string name)
	{
		return null;
	}
}
