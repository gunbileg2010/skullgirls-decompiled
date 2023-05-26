using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UDP;

public class MoneyServiceUDP : MonoBehaviour, IMoneyService, IInitListener, IPurchaseListener
{
	private bool isInitialized;

	private List<PurchaseInfo> unconsumedPurchases;

	private Action<bool> initCallback;

	private Action<List<ProductData>, string> getProductDataCallback;

	private Action<MoneyPurchaseResult, PurchaseData> purchaseCallback;

	private Action<bool> finishPurchaseCallback;

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

	public void Purchase(string productId, Action<MoneyPurchaseResult, PurchaseData> callback)
	{
	}

	public void FinishPurchase(string productId, Action<bool> callback)
	{
	}

	public void GetUnfinishedPurchases(Action<List<PurchaseData>> callback)
	{
	}

	public void OnInitialized(UserInfo userInfo)
	{
	}

	public void OnInitializeFailed(string message)
	{
	}

	public void OnQueryInventory(Inventory inventory)
	{
	}

	public void OnQueryInventoryFailed(string message)
	{
	}

	public void OnPurchasePending(string message, PurchaseInfo purchaseInfo)
	{
	}

	public void OnPurchase(PurchaseInfo purchaseInfo)
	{
	}

	public void OnPurchaseFailed(string message, PurchaseInfo purchaseInfo)
	{
	}

	public void OnPurchaseRepeated(string productCode)
	{
	}

	public void OnPurchaseConsume(PurchaseInfo purchaseInfo)
	{
	}

	public void OnPurchaseConsumeFailed(string message, PurchaseInfo purchaseInfo)
	{
	}

	private PurchaseInfo GetUnconsumedPurchaseFor(string productId)
	{
		return null;
	}

	private PurchaseData CreatePurchaseDataFromPurchase(PurchaseInfo purchase)
	{
		return null;
	}
}
