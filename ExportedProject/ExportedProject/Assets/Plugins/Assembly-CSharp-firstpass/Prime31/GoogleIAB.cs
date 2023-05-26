using System.Collections.Generic;
using UnityEngine;

namespace Prime31
{
	public class GoogleIAB
	{
		private static AndroidJavaObject _plugin;

		static GoogleIAB()
		{
		}

		public static void enableLogging(bool shouldEnable)
		{
		}

		public static void setAutoVerifySignatures(bool shouldVerify)
		{
		}

		public static void init(string publicKey)
		{
		}

		public static void unbindService()
		{
		}

		public static bool areSubscriptionsSupported()
		{
			return false;
		}

		public static void queryInventory(string[] skus)
		{
		}

		public static List<GooglePurchase> getPurchaseHistory()
		{
			return null;
		}

		public static void purchaseProduct(string sku)
		{
		}

		public static void consumeProduct(string sku)
		{
		}

		public static void acknowledgePurchase(string sku)
		{
		}
	}
}
