using System;
using System.Collections.Generic;
using UnityEngine;

public class MoneyServiceDummy : MonoBehaviour, IMoneyService
{
	public string GetName()
	{
		return null;
	}

	public void Init(string key, Action<bool> callback)
	{
	}

	public void Shutdown()
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	public void GetProductData(string[] productIds, Action<List<ProductData>, string> callback)
	{
	}

	public void GetUnfinishedPurchases(Action<List<PurchaseData>> callback)
	{
	}

	public bool DoesUnfinishedPurchaseExist(string productId)
	{
		return false;
	}

	public void Purchase(string productId, Action<MoneyPurchaseResult, PurchaseData> callback)
	{
	}

	public void FinishPurchase(string productId, Action<bool> callback)
	{
	}
}
