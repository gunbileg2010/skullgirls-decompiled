using System;
using System.Collections.Generic;

public class UserOfferServerData : OfferServerData
{
	private string id;

	private DateTime expirationDate;

	public int remainingPurchases;

	public UserOfferServerData(Dictionary<string, object> dataDict)
	{
	}

	public override string GetOfferId()
	{
		return null;
	}

	public override bool IsAvailable()
	{
		return false;
	}

	public override DateTime GetExpirationDate()
	{
		return default(DateTime);
	}

	public override int GetRemainingPurchases()
	{
		return 0;
	}

	public override void DecrementRemainingPurchases()
	{
	}
}
