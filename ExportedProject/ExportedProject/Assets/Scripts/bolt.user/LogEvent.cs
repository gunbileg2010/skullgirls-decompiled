using System;
using Bolt;

public class LogEvent : Event
{
	public string Message
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public NetworkId NetworkId
	{
		get
		{
			return default(NetworkId);
		}
		set
		{
		}
	}

	public override string ToString()
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(BoltEntity entity)
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	[Obsolete]
	private static LogEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(BoltConnection connection)
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise()
	{
		return null;
	}

	[Obsolete]
	public static LogEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	public static LogEvent Create(BoltEntity entity)
	{
		return null;
	}

	public static LogEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	private static LogEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	public static LogEvent Create(GlobalTargets targets)
	{
		return null;
	}

	public static LogEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	public static LogEvent Create(BoltConnection connection)
	{
		return null;
	}

	public static LogEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	public static LogEvent Create()
	{
		return null;
	}

	public static LogEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
