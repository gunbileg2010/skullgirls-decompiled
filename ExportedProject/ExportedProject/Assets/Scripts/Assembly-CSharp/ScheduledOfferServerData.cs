using System;
using System.Collections.Generic;

public class ScheduledOfferServerData : OfferServerData
{
	private class ScheduledServerOfferInstance
	{
		public string id;

		public int productIndex;

		public int remainingPurchases;

		public ScheduleServerData schedule;

		public ScheduledServerOfferInstance(Dictionary<string, object> data)
		{
		}
	}

	private List<ScheduledServerOfferInstance> instances;

	private ScheduledServerOfferInstance current;

	public ScheduledOfferServerData(Dictionary<string, object> dataDict)
	{
	}

	public override string GetOfferId()
	{
		return null;
	}

	public override DateTime GetExpirationDate()
	{
		return default(DateTime);
	}

	public override int GetActivePurchaseIndex()
	{
		return 0;
	}

	public override bool IsOnSale()
	{
		return false;
	}

	public override int GetRemainingPurchases()
	{
		return 0;
	}

	public override void DecrementRemainingPurchases()
	{
	}
}
