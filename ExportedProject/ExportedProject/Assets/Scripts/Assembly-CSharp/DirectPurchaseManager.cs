using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DirectPurchaseManager : MonoBehaviour
{
	public const string kPurchaseRefreshMetricsGUID = "directPurchaseRefresh";

	private DirectPurchaseStoreServerData cachedStoreData;

	private bool gettingStoreData;

	private Action<DirectPurchaseStoreServerData> getStoreDataRequestCallacks;

	public event Action StoreUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public DirectPurchaseStoreServerData GetCachedStoreData()
	{
		return null;
	}

	public void GetStoreData(Action<DirectPurchaseStoreServerData> callback = null, bool rerollAllowed = true)
	{
	}

	public void RefreshStoreData(Action<DirectPurchaseStoreServerData> callback = null)
	{
	}

	public void BuyOffer(string storeType, long itemId, Price price, Action<NetworkRequest> callback = null, Action<IPopup> rewardsPopupCallback = null)
	{
	}

	private void InvalidateCachedData()
	{
	}

	private void OnLogin(AuthenticateRequest authRequest)
	{
	}
}
