using System;
using System.Collections.Generic;
using Prime31;
using UnityEngine;

public class MoneyServiceGoogle : MonoBehaviour, IMoneyService
{
	private bool isInitialized;

	private List<GooglePurchase> unconsumedPurchases;

	private Action<bool> initCallback;

	private Action<List<ProductData>, string> getProductDataCallback;

	private Action<MoneyPurchaseResult, PurchaseData> purchaseCallback;

	private Action<bool> finishPurchaseCallback;

	private void OnApplicationQuit()
	{
	}

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

	private GooglePurchase GetUnconsumedPurchaseFor(string productId)
	{
		return null;
	}

	private PurchaseData CreatePurchaseDataFromPurchase(GooglePurchase purchase)
	{
		return null;
	}

	private void OnBillingSupported()
	{
	}

	private void OnBillingNotSupported(string error)
	{
	}

	private void OnQueryInventorySucceeded(List<GooglePurchase> purchasedItems, List<GoogleSkuInfo> forSaleItems)
	{
	}

	private void OnQueryInventoryFailed(string error)
	{
	}

	private void OnPurchaseSucceeded(GooglePurchase purchase)
	{
	}

	private void OnPurchaseFailed(string error, int response)
	{
	}

	private void OnConsumePurchaseSucceeded(GooglePurchase purchase)
	{
	}

	private void OnConsumePurchaseFailed(string error)
	{
	}

	private void LogError(string prefix, string error)
	{
	}
}
