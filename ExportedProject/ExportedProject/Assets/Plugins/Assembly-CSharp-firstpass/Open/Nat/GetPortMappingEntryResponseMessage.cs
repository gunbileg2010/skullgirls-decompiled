using System.Runtime.CompilerServices;
using System.Xml;

namespace Open.Nat
{
	internal class GetPortMappingEntryResponseMessage : ResponseMessageBase
	{
		public string RemoteHost
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

		public int ExternalPort
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Protocol Protocol
		{
			[CompilerGenerated]
			get
			{
				return default(Protocol);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int InternalPort
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string InternalClient
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

		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string PortMappingDescription
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

		public int LeaseDuration
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal GetPortMappingEntryResponseMessage(XmlDocument response, string serviceType, bool genericMapping)
			: base(null, null, null)
		{
		}
	}
}
