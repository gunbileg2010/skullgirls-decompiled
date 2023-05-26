using System;
using System.Text;
using UdpKit;

public abstract class DirectConnectionCandidateBase
{
	public enum ConnectionStatus
	{
		Idle = 0,
		Initializing = 1,
		LocalInfoCollected = 2,
		OpponentInfoCollected = 3,
		Testing = 4,
		Available = 5,
		Unavailable = 6
	}

	protected ConnectionStatus status;

	protected bool isAvailableToOpponent;

	public ConnectionStatus GetConnectionStatus()
	{
		return default(ConnectionStatus);
	}

	public abstract void Init(bool isHost, Action initCompleteCallback);

	public virtual bool IsInitialized()
	{
		return false;
	}

	public abstract void WriteInfoForOpponent(UdpPacket packet);

	public abstract void ReadInfoFromOpponent(UdpPacket packet);

	public abstract void DiscoverAndMeasureConnections(Action discoveryCompleteCallback);

	public virtual bool IsDiscoveryComplete()
	{
		return false;
	}

	public abstract void Cleanup();

	public virtual void SetOpponentConnectionAvailability(bool value)
	{
	}

	public virtual bool IsAvailableToPlayer()
	{
		return false;
	}

	public virtual bool IsAvailableToOpponent()
	{
		return false;
	}

	public virtual bool IsAvailableToPlayerAndOpponent()
	{
		return false;
	}

	public virtual int GetMyPingMs()
	{
		return 0;
	}

	public abstract void SetOpponentPingMs(int value);

	public virtual int GetOpponentPingMs()
	{
		return 0;
	}

	public abstract void LogStatusToStringBuilder(StringBuilder stringBuilder);
}
