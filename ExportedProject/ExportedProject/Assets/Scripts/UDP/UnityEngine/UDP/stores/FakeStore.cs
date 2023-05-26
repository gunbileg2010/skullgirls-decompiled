using System.Collections.Generic;

namespace UnityEngine.UDP.stores
{
	public class FakeStore : IUdpStore
	{
		private List<ProductInfo> productCatalog;

		private readonly List<PurchaseInfo> purchaseList;

		private bool debugEnabled;

		private string logTag;

		public void Initialize(IInitListener listener, AppInfo appInfo)
		{
		}

		public void LicenseCheck(ILicensingListener licensingListener)
		{
		}

		public void Purchase(string productId, string gameOrderId, string developerPayload, IPurchaseListener listener)
		{
		}

		public void Purchase(string productId, string developerPayload, IPurchaseListener listener)
		{
		}

		public void QueryInventory(IPurchaseListener listener)
		{
		}

		public void QueryInventory(List<string> productIds, IPurchaseListener listener)
		{
		}

		public void ConsumePurchase(PurchaseInfo purchaseInfo, IPurchaseListener listener)
		{
		}

		public void ConsumePurchase(List<PurchaseInfo> purchaseInfos, IPurchaseListener listener)
		{
		}

		public void EnableDebugLogging(bool enable)
		{
		}

		public void EnableDebugLogging(bool enable, string tag)
		{
		}

		public string GetStoreName()
		{
			return null;
		}

		private Inventory BuildInventory()
		{
			return null;
		}

		private Inventory BuildInventory(List<string> productIds)
		{
			return null;
		}

		private void RemovePurchaseInfoByOrderId(string orderId)
		{
		}

		private void Log(string msg)
		{
		}
	}
}
