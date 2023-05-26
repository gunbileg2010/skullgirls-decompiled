using System;
using Bolt;
using UnityEngine;

public class FlashColorEvent : Event
{
	public Color FlashColor
	{
		get
		{
			return default(Color);
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
	public static FlashColorEvent Raise(BoltEntity entity)
	{
		return null;
	}

	[Obsolete]
	public static FlashColorEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	public static FlashColorEvent Create(BoltEntity entity)
	{
		return null;
	}

	public static FlashColorEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}
}
