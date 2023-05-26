using System;
using System.Collections.Generic;
using UnityEngine.UDP.stores;

namespace UnityEngine.UDP
{
	public class StoreService
	{
		private static IUdpStore storeInstance;

		public static string StoreName => null;

		public static void Initialize(IInitListener listener, AppInfo appInfo = null)
		{
		}

		public static void LicenseCheck(ILicensingListener licensingListener)
		{
		}

		[Obsolete]
		public static void Purchase(string productId, string gameOrderId, string developerPayload, IPurchaseListener listener)
		{
		}

		public static void Purchase(string productId, string developerPayload, IPurchaseListener listener)
		{
		}

		public static void QueryInventory(IPurchaseListener listener)
		{
		}

		public static void QueryInventory(List<string> productIds, IPurchaseListener listener)
		{
		}

		public static void ConsumePurchase(PurchaseInfo purchaseInfo, IPurchaseListener listener)
		{
		}

		public static void ConsumePurchase(List<PurchaseInfo> purchaseInfos, IPurchaseListener listener)
		{
		}

		public static void EnableDebugLogging(bool enable)
		{
		}

		public static void EnableDebugLogging(bool enable, string tag)
		{
		}
	}
}
