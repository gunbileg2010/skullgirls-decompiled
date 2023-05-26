using System;
using System.Collections.Generic;
using UnityEngine;

public class RewardCalendar : GuidScriptableObject, IServerUploadable
{
	public enum ResetMode
	{
		None = 0,
		Monthly = 1
	}

	[Serializable]
	public class CalenderIconOverride
	{
		public int targetIndex;

		public Loot overrideLoot;

		public string overrideTooltipHeader;

		public string overrideTooltipDesc;

		public bool displayAsRandom;
	}

	[SerializeField]
	private string title;

	[SerializeField]
	private string description;

	[SerializeField]
	private TalkingHeadEmoteAndOffset talkingHead;

	[SerializeField]
	private int displayOrder;

	[SerializeField]
	private bool useBigBoxForLastReward;

	[SerializeField]
	private ResetMode resetMode;

	[SerializeField]
	private int expireAfterDays;

	[SerializeField]
	private bool onlyShowCurrentDay;

	[SerializeField]
	private bool countDaysRemainingInDescription;

	[SerializeField]
	private List<Loot> loots;

	[SerializeField]
	private List<CalenderIconOverride> iconOverrides;

	public string GetTitle()
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	public TalkingHeadEmoteAndOffset GetTalkingHead()
	{
		return null;
	}

	public int GetDisplayOrder()
	{
		return 0;
	}

	public int GetTotalRewardDays()
	{
		return 0;
	}

	public bool UseBigBoxForLastReward()
	{
		return false;
	}

	public List<Loot> GetLoots()
	{
		return null;
	}

	public Loot GetLootForDay(int day)
	{
		return null;
	}

	public List<CalenderIconOverride> GetCalenderIconOverrides()
	{
		return null;
	}

	public bool GetOnlyShowCurrentDay()
	{
		return false;
	}

	public bool GetCountDaysRemainingInDescription()
	{
		return false;
	}

	public ResetMode GetResetMode()
	{
		return default(ResetMode);
	}

	public override bool HasIssues()
	{
		return false;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
