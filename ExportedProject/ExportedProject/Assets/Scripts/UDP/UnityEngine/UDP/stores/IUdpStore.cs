using System.Collections.Generic;

namespace UnityEngine.UDP.stores
{
	public interface IUdpStore
	{
		void Initialize(IInitListener listener, AppInfo appInfo);

		void LicenseCheck(ILicensingListener licensingListener);

		void Purchase(string productId, string gameOrderId, string developerPayload, IPurchaseListener listener);

		void Purchase(string productId, string developerPayload, IPurchaseListener listener);

		void QueryInventory(IPurchaseListener listener);

		void QueryInventory(List<string> productIds, IPurchaseListener listener);

		void ConsumePurchase(PurchaseInfo purchaseInfo, IPurchaseListener listener);

		void ConsumePurchase(List<PurchaseInfo> purchaseInfos, IPurchaseListener listener);

		void EnableDebugLogging(bool enable);

		void EnableDebugLogging(bool enable, string tag);

		string GetStoreName();
	}
}
