using System.Collections;
using System.Runtime.CompilerServices;
using BoltInternal;

namespace Bolt.Services
{
	public class CCUService : GlobalEventListenerBase
	{
		private class CCUReport
		{
			public int Total
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string LicenseKey
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string AppId
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private readonly float PublishInterval;

		private readonly string ServerUrl;

		private string AppId;

		private string LicenseKey;

		public override void BoltStartDone()
		{
		}

		private IEnumerator SendReport()
		{
			return null;
		}

		private void SendData(string serverUrl, string appId, string licenseKey, int total)
		{
		}

		private string BuildURL(string baseURL, string appID, string license, int total)
		{
			return null;
		}
	}
}
