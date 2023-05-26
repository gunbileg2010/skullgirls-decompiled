using System;
using System.Collections.Generic;
using UnityEngine;

public class LimitedTimeOfferData : OfferData, IServerUploadable
{
	[SerializeField]
	private bool isMoneyOffer;

	[SerializeField]
	protected List<MoneyPurchaseAction> pricePoints;

	[SerializeField]
	protected List<CurrencyPurchaseAction> currencyPricePoints;

	public override void ExecutePurchase(OfferServerData offerData, string context, Action<bool> callback)
	{
	}

	public override PurchaseAction GetPurchaseActionAtIndex(int index)
	{
		return null;
	}

	public override List<PurchaseAction> GetAllPurchaseActions()
	{
		return null;
	}

	public override bool HasIssues()
	{
		return false;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
