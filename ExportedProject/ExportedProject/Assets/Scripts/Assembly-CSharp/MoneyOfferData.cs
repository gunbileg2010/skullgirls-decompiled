using System;
using System.Collections.Generic;
using UnityEngine;

public class MoneyOfferData : OfferData, IServerUploadable
{
	[SerializeField]
	protected List<MoneyPurchaseAction> pricePoints;

	[SerializeField]
	protected string overrideOfferWithGuid;

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

	public List<MoneyPurchaseAction> GetMoneyPurchaseActions()
	{
		return null;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
