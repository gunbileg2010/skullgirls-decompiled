using System.Collections.Generic;
using UnityEngine;

public class EventSet : GameContentSet, IServerUploadable
{
	[SerializeField]
	private bool mutuallyExclusive;

	public bool IsMutuallyExclusive()
	{
		return false;
	}

	public EventData GetEnteredEvent()
	{
		return null;
	}

	public EventData GetFirstAvailableEvent()
	{
		return null;
	}

	public int GetAvailableEventCount()
	{
		return 0;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
