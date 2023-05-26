using System;
using System.Collections.Generic;
using UnityEngine;

public class MoneyServiceStoreKit : MonoBehaviour, IMoneyService
{
	private bool isInitialized;

	private Action<List<ProductData>, string> getProductDataCallback;

	private Action<MoneyPurchaseResult, PurchaseData> purchaseCallback;

	private Action<string> receiptCallback;

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

	private void OnProductListRequestFailed(string error)
	{
	}

	private void OnPurchaseFailed(string error)
	{
	}

	private void OnPurchaseCancelled(string error)
	{
	}

	private void GetReceipt(Action<string> callback)
	{
	}

	private void OnRefreshReceiptSucceeded()
	{
	}

	private void OnRefreshReceiptFailed(string error)
	{
	}
}
