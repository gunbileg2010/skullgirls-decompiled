using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MailRewardFilter
{
	[SerializeField]
	private Loot filterLoot;

	[SerializeField]
	[Timestamp]
	private long filterDate;

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}
}
