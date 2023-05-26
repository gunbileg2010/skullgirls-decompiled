using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventData : GameContentData, IServerUploadable
{
	[Serializable]
	public class ShowcasedLoot
	{
		public Loot loot;

		public int multiplier;

		public string descriptionText;

		public string tooltipText;

		public bool unknown;
	}

	[SerializeField]
	private string eventNotification;

	public ShowcasedLoot[] showcasedLoots;

	public List<LootTable.WeightedLoot> randomDropLoots;

	public override bool IsAvailable()
	{
		return false;
	}

	public abstract EventDataType GetEventType();

	public string GetEventNotification()
	{
		return null;
	}

	public virtual long GetMinScore()
	{
		return 0L;
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public virtual List<EventReward> GetEventRewards()
	{
		return null;
	}

	public virtual List<Dictionary<string, object>> GetServerRewardsList()
	{
		return null;
	}
}
