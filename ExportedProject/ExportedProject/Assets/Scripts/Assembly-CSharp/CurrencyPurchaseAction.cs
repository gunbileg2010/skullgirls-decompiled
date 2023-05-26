using System;
using System.Collections.Generic;

[Serializable]
public class CurrencyPurchaseAction : PurchaseAction
{
	public string productId;

	public Price price;

	public override string GetProductId()
	{
		return null;
	}

	public Price GetPrice()
	{
		return null;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override void UpdateFromGameDefinition(Dictionary<string, object> dataDict)
	{
	}
}
