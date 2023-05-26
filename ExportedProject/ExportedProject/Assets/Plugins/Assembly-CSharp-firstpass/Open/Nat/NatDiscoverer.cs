using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Open.Nat
{
	public class NatDiscoverer
	{
		public static readonly TraceSource TraceSource;

		private static readonly Dictionary<string, NatDevice> Devices;

		private static readonly Finalizer Finalizer;

		internal static readonly Timer RenewTimer;

		public Task<NatDevice> DiscoverDeviceAsync()
		{
			return null;
		}

		public Task<NatDevice> DiscoverDeviceAsync(PortMapper portMapper, CancellationTokenSource cancellationTokenSource)
		{
			return null;
		}

		public Task<IEnumerable<NatDevice>> DiscoverDevicesAsync(PortMapper portMapper, CancellationTokenSource cancellationTokenSource)
		{
			return null;
		}

		private Task<IEnumerable<NatDevice>> DiscoverAsync(PortMapper portMapper, bool onlyOne, CancellationTokenSource cts)
		{
			return null;
		}

		public static void ReleaseAll()
		{
		}

		internal static void ReleaseSessionMappings()
		{
		}

		private static void RenewMappings(object state)
		{
		}
	}
}
