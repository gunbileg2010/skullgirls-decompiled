using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Prime31
{
	public class GoogleIABManager : AbstractManager
	{
		public static event Action billingSupportedEvent
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

		public static event Action<string> billingNotSupportedEvent
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

		public static event Action<List<GooglePurchase>, List<GoogleSkuInfo>> queryInventorySucceededEvent
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

		public static event Action<string> queryInventoryFailedEvent
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

		public static event Action<GooglePurchase> purchaseSucceededEvent
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

		public static event Action<string, int> purchaseFailedEvent
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

		public static event Action<GooglePurchase> consumePurchaseSucceededEvent
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

		public static event Action<string> consumePurchaseFailedEvent
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

		public static event Action<GooglePurchase> acknowledgePurchaseSucceededEvent
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

		public static event Action<string> acknowledgePurchaseFailedEvent
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

		static GoogleIABManager()
		{
		}

		public void billingSupported(string empty)
		{
		}

		public void billingNotSupported(string error)
		{
		}

		public void queryInventorySucceeded(string json)
		{
		}

		public void queryInventoryFailed(string error)
		{
		}

		public void purchaseSucceeded(string json)
		{
		}

		public void purchaseFailed(string json)
		{
		}

		public void consumePurchaseSucceeded(string json)
		{
		}

		public void consumePurchaseFailed(string error)
		{
		}

		public void acknowledgePurchaseSucceeded(string json)
		{
		}

		public void acknowledgePurchaseFailed(string error)
		{
		}
	}
}
