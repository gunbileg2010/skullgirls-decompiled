using System;
using System.Collections.Generic;
using UnityEngine;

public class SubscriptionOfferData : MoneyOfferData, IServerUploadable
{
	[SerializeField]
	private RewardCalendar subscriptionCalendar;

	public override void ExecutePurchase(OfferServerData offerData, string context, Action<bool> callback)
	{
	}

	public RewardCalendar GetCalendar()
	{
		return null;
	}

	public string GetCalendarGuid()
	{
		return null;
	}

	public Loot GetDailyLoot()
	{
		return null;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
