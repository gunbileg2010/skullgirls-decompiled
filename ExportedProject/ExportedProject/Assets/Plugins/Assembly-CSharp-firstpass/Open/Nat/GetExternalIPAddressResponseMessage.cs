using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Open.Nat
{
	internal class GetExternalIPAddressResponseMessage : ResponseMessageBase
	{
		public IPAddress ExternalIPAddress
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GetExternalIPAddressResponseMessage(XmlDocument response, string serviceType)
			: base(null, null, null)
		{
		}
	}
}
