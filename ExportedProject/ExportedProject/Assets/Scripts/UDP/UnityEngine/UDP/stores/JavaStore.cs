using System.Collections.Generic;

namespace UnityEngine.UDP.stores
{
	public class JavaStore : IUdpStore
	{
		private static AndroidJavaClass serviceClass;

		private const string CHANNEL_SERVICE = "com.unity.udp.sdk.ChannelService";

		private const string UNITY_PLAYER = "com.unity3d.player.UnityPlayer";

		private const string APP_INFO = "com.unity.udp.sdk.AppInfo";

		private const string PURCHASE_INFO = "com.unity.udp.sdk.PurchaseInfo";

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

		private static AndroidJavaObject JavaArrayFromCsList(List<string> values)
		{
			return null;
		}

		private static AndroidJavaClass SafetyServiceClass()
		{
			return null;
		}
	}
}
