using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EventTierMapping
{
	public enum EventTierType
	{
		Rank = 0,
		Percentile = 1
	}

	[HideInInspector]
	public EventTierType tierMappingType;

	public int threshold;

	public RiftTier riftTier;

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
