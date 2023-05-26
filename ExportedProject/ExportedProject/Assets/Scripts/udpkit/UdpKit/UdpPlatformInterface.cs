using System.Runtime.CompilerServices;

namespace UdpKit
{
	public abstract class UdpPlatformInterface
	{
		internal object Token
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

		internal abstract string Name { get; }

		internal abstract byte[] PhysicalAddress { get; }

		internal abstract UdpLinkType LinkType { get; }

		internal abstract UdpIPv4Address[] UnicastAddresses { get; }

		internal abstract UdpIPv4Address[] MulticastAddresses { get; }

		internal abstract UdpIPv4Address[] GatewayAddresses { get; }
	}
}
