using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GachaServerData
{
	public string guid;

	public GachaData.Type type;

	public float timeLeftToEarn;

	public bool currentlyActive;

	private GachaData _clientData;

	public DateTime availableDate
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool claimed
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool limitedTimeAvailability
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DateTime startDateTime
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DateTime endDateTime
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GachaData ClientData => null;

	public GachaServerData()
	{
	}

	public GachaServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public bool IsAvailableAtThisTime()
	{
		return false;
	}

	public void MarkAsClaimed()
	{
	}
}
