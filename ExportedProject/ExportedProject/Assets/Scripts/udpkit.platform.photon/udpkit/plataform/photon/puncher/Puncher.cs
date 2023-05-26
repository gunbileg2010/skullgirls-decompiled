using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UdpKit;
using UnityEngine;

namespace udpkit.plataform.photon.puncher
{
	internal class Puncher
	{
		public PunchAPI.PunchStatus punchStatus;

		public IPunchLoadBalancingClient loadBalancingClient;

		public UdpEndPoint localEndPoint;

		private readonly Socket socket;

		private StunManager stunManager;

		private List<int> blackList;

		private List<int> whiteList;

		private Dictionary<int, PunchConnection> punchConnections;

		private PunchInfo _localPunchInfo;

		private List<int> auxToRemove;

		public PunchInfo LocalPunchInfo => null;

		public Puncher(Socket socket)
		{
		}

		public void Clear()
		{
		}

		public void Service()
		{
		}

		public void HandlerPhotonEvent(byte evtCode, int remotePlayerId, string evtData)
		{
		}

		public void RecvFrom(byte[] buffer, UdpEndPoint endpoint)
		{
		}

		public int Send(byte[] data, EndPoint target)
		{
			return 0;
		}

		public int Send(byte[] data, int bytesToSend, EndPoint target)
		{
			return 0;
		}

		private void ProcessStun()
		{
		}

		private void Service_PunchConnections()
		{
		}

		private void HandlePlayerJoin(int remotePlayerId)
		{
		}

		private void HandlePunchInfo(int remotePlayerId, string evtData)
		{
		}

		private void HandlePing(int remoteId)
		{
		}

		private void HandlePong(int remoteId)
		{
		}

		private void SendPing(PunchConnection punnConnection)
		{
		}

		private void SendPong(PunchConnection punnConnection)
		{
		}

		private IEnumerator<CustomYieldInstruction> SendRoutine(byte[] data, int bytesToSend, EndPoint target, int tries = 3, int interval = 100)
		{
			return null;
		}
	}
}
