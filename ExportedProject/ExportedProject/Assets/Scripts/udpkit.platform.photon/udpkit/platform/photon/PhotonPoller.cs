using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UdpKit;
using UnityEngine;
using udpkit.platform.photon.realtime;

namespace udpkit.platform.photon
{
	internal abstract class PhotonPoller : MonoBehaviour, IOnEventCallback
	{
		internal class PhotonPacket
		{
			public byte[] Data;

			public int Remote;

			public PhotonPacket()
			{
			}

			public PhotonPacket(int size)
			{
			}
		}

		private class SynchronizedQueue<T>
		{
			private readonly Queue<T> queue;

			public int Count => 0;

			public void Clear()
			{
			}

			public void Enqueue(T item)
			{
			}

			public bool TryDequeue(out T item)
			{
				item = default(T);
				return false;
			}
		}

		private const byte DATA_EVENT_CODE = 150;

		private object _joinToken;

		private long _currentConnectRoutine;

		private Action<bool> _currentAsyncCallback;

		private PhotonPlatformConfig _config;

		private PhotonClient _lbClient;

		private ClientState _state;

		private SynchronizedQueue<PhotonPacket> _packetPool;

		private SynchronizedQueue<PhotonPacket> _packetSend;

		private SynchronizedQueue<PhotonPacket> _packetRecv;

		private static PhotonPoller _instance;

		private static Type _externalType;

		private readonly RaiseEventOptions _cachedEvtOptions;

		private readonly SendOptions _cachedEvtSendOptions;

		private Dictionary<ConnectState, ConnectState[]> _stateTransitions;

		public LoadBalancingClient LoadBalancerClient => null;

		public static PhotonPoller Instance => null;

		public int HostPlayerId => 0;

		private ConnectState ConnectState
		{
			[CompilerGenerated]
			get
			{
				return default(ConnectState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static PhotonPoller()
		{
		}

		public static void CreatePoller(PhotonPlatformConfig config, bool force = false)
		{
		}

		protected internal void StartPhotonClient(UdpEndPoint endPoint)
		{
		}

		protected void StopPhotonClient()
		{
		}

		protected void Update()
		{
		}

		internal static void StartDone()
		{
		}

		internal static void RegisterInstance<T>() where T : PhotonPoller
		{
		}

		private static void InstatiatePoller(out PhotonPoller photonPoller)
		{
			photonPoller = null;
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		internal static void ConnectFailed(bool refused = false)
		{
		}

		internal static void Connected()
		{
		}

		private void HandlerOperationResponse(OperationResponse response)
		{
		}

		public void OnEvent(EventData photonEvent)
		{
		}

		private void HandleStateChanged(ClientState arg1, ClientState arg2)
		{
		}

		private void PollOut()
		{
		}

		internal static void OnConnectStateChange(ConnectState state)
		{
		}

		internal static bool SetHostInfo(UdpSession session, Action<bool> result)
		{
			return false;
		}

		public static bool JoinSession(UdpSession session, object token, Action<bool> result)
		{
			return false;
		}

		public static List<UdpSession> GetSessions()
		{
			return null;
		}

		internal static void UpdateBestRegion(PhotonRegion region)
		{
		}

		internal static void BoltConnect(UdpEndPoint endPoint)
		{
		}

		internal static void BoltDisconnect()
		{
		}

		internal static void BoltUpdateSessionList(Map<Guid, UdpSession> sessions)
		{
		}

		internal static bool BoltIsClient()
		{
			return false;
		}

		internal static UdpEndPoint BoltEndPoint()
		{
			return default(UdpEndPoint);
		}

		protected internal abstract void BoltConnectInternal(UdpEndPoint endPoint, object token);

		protected internal abstract void BoltDisconnectInternal(DisconnectCause disconnectedCause);

		protected internal abstract void BoltUpdateSessionListInternal(Map<Guid, UdpSession> sessions);

		protected internal abstract bool BoltIsClientInternal();

		protected internal abstract UdpEndPoint BoltEndPointInternal();

		internal PhotonPacket AllocPacket(int size)
		{
			return null;
		}

		internal void FreePacket(PhotonPacket packet)
		{
		}

		internal static int RecvFrom(byte[] buffer, ref UdpEndPoint endpoint)
		{
			return 0;
		}

		internal static bool RecvPoll()
		{
			return false;
		}

		internal static int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
		{
			return 0;
		}

		private byte[] CloneArray(byte[] array, int size)
		{
			return null;
		}

		private IEnumerator<CustomYieldInstruction> SetHostInfoRoutine(UdpSession session, Action<bool> result = null)
		{
			return null;
		}

		private IEnumerator<CustomYieldInstruction> JoinSessionRoutine(UdpSession session, object token, Action<bool> result = null)
		{
			return null;
		}

		private IEnumerator<CustomYieldInstruction> FailedJoinCallback()
		{
			return null;
		}

		internal static void ChangeState(ConnectState state)
		{
		}
	}
}
