using System;
using System.Runtime.CompilerServices;
using Bolt;

[Serializable]
public sealed class BoltConfig
{
	public int framesPerSecond;

	public int packetSize;

	public int packetMaxEventSize;

	public int maxEntityPriority;

	public int maxPropertyPriority;

	public ScopeMode scopeMode;

	public BoltConfigLogTargets logTargets;

	public bool disableDejitterBuffer;

	public int clientSendRate;

	public int clientDejitterDelay;

	public int clientDejitterDelayMin;

	public int clientDejitterDelayMax;

	public int serverSendRate;

	public int serverDejitterDelay;

	public int serverDejitterDelayMin;

	public int serverDejitterDelayMax;

	public int serverConnectionLimit;

	public BoltConnectionAcceptMode serverConnectionAcceptMode;

	public int commandQueueSize;

	public int commandRedundancy;

	public float commandPingMultiplier;

	public bool useNetworkSimulation;

	public float simulatedLoss;

	public int simulatedPingMean;

	public int simulatedPingJitter;

	public BoltRandomFunction simulatedRandomFunction;

	public int connectionTimeout;

	public int connectionRequestTimeout;

	public int connectionRequestAttempts;

	public bool disableAutoSceneLoading;

	public bool EnableIPv6;

	public int commandDejitterDelay
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	internal int commandDejitterDelayMin => 0;

	internal int commandDejitterDelayMax => 0;

	internal BoltConfig Clone()
	{
		return null;
	}
}
