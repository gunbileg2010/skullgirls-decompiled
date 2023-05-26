using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.UDP
{
	[Serializable]
	public class UdpIapBridge : IInitListener, IPurchaseListener
	{
		private Action<bool, string> m_PurchaseCallback;

		private Action<bool, string> m_InitCallback;

		private Action<bool, object> m_RetrieveProductsCallback;

		private Inventory m_Inventory;

		private Dictionary<string, PurchaseInfo> m_LocalPurchasesCache;

		private bool m_InitOperating;

		private const string PURCHASE_PENDING_CODE = "-303";

		public void Initialize(Action<bool, string> callback)
		{
		}

		public void Purchase(string productId, Action<bool, string> callback, string developerPayload = null)
		{
		}

		public void RetrieveProducts(ReadOnlyCollection<string> productIds, Action<bool, object> callback)
		{
		}

		public void FinishTransaction(string transactionId)
		{
		}

		private PurchaseInfo FindPurchaseInfo(string transactionId)
		{
			return null;
		}

		public void OnInitialized(UserInfo userInfo)
		{
		}

		public void OnInitializeFailed(string message)
		{
		}

		public void OnPurchase(PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchaseFailed(string message, PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchasePending(string message, PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchaseRepeated(string productId)
		{
		}

		public void OnPurchaseConsume(PurchaseInfo purchaseInfo)
		{
		}

		public void OnPurchaseConsumeFailed(string message, PurchaseInfo purchaseInfo)
		{
		}

		public void OnQueryInventory(Inventory inventory)
		{
		}

		public void OnQueryInventoryFailed(string message)
		{
		}

		internal static Dictionary<string, string> StringPropertyToDictionary(object info)
		{
			return null;
		}
	}
}
