using System;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
	[SerializeField]
	private bool debug;

	private IMoneyService moneyService;

	private void OnDestroy()
	{
	}

	public void Init(string key, bool forceDummy, int maxRetries, Action<bool> callback)
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

	public void Purchase(string productId, Action<MoneyPurchaseResult, PurchaseData> purchaseCallback)
	{
	}

	public void FinishPurchase(string productId, Action<bool> callback)
	{
	}

	public void GetUnfinishedPurchases(Action<List<PurchaseData>> callback)
	{
	}

	public string GetMoneyServiceName()
	{
		return null;
	}
}
