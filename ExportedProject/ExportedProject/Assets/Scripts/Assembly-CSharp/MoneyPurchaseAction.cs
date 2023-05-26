using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MoneyPurchaseAction : PurchaseAction
{
	public string appleProductId;

	public string googleProductId;

	[SerializeField]
	private string placeholderPrice;

	private string displayPrice;

	private double price;

	private string currencyCode;

	public override string GetProductId()
	{
		return null;
	}

	public override bool HasProductId(string productId)
	{
		return false;
	}

	public void SetDisplayPrice(string displayPrice)
	{
	}

	public string GetDisplayPrice()
	{
		return null;
	}

	public override bool IsReadyToBePurchased()
	{
		return false;
	}

	public void SetPrice(double price)
	{
	}

	public double GetPrice()
	{
		return 0.0;
	}

	public void SetCurrencyCode(string currencyCode)
	{
	}

	public string GetCurrencyCode()
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
