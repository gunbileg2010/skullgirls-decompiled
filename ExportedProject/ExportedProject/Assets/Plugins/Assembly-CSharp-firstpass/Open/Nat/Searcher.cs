using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Open.Nat
{
	internal abstract class Searcher
	{
		private readonly List<NatDevice> _devices;

		protected List<UdpClient> UdpClients;

		public EventHandler<DeviceEventArgs> DeviceFound;

		internal DateTime NextSearch;

		public Task<IEnumerable<NatDevice>> Search(CancellationToken cancelationToken)
		{
			return null;
		}

		private void Discover(CancellationToken cancelationToken)
		{
		}

		private void Receive(CancellationToken cancelationToken)
		{
		}

		protected abstract void Discover(UdpClient client, CancellationToken cancelationToken);

		public abstract NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint);

		public void CloseUdpClients()
		{
		}

		private void RaiseDeviceFound(NatDevice device)
		{
		}
	}
}
