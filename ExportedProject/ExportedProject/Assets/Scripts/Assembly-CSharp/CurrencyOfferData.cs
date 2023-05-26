using System.Collections.Generic;
using UnityEngine;

public class CurrencyOfferData : OfferData, IServerUploadable
{
	[SerializeField]
	private List<CurrencyPurchaseAction> pricePoints;

	public override PurchaseAction GetPurchaseActionAtIndex(int index)
	{
		return null;
	}

	public override List<PurchaseAction> GetAllPurchaseActions()
	{
		return null;
	}

	public List<CurrencyPurchaseAction> GetPurchaseActions()
	{
		return null;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
