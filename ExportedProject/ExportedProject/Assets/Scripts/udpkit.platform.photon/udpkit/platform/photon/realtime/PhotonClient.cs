using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UdpKit;
using udpkit.plataform.photon.puncher;

namespace udpkit.platform.photon.realtime
{
	internal class PhotonClient : LoadBalancingClient, IConnectionCallbacks, ILobbyCallbacks, IInRoomCallbacks, IMatchmakingCallbacks, IPunchLoadBalancingClient
	{
		private Dictionary<int, RoomInfo> _roomInfoMap;

		private List<RoomInfo> _roomList;

		private bool _roomChanged;

		private readonly object _roomInfoLock;

		private readonly string _originalNameServerHost;

		private readonly string _originalNameServerHttp;

		private Action<bool> _connectToRegionCallback;

		private const string SERVER_HOST_CN = "ns-cn.exitgames.com";

		private const string SERVER_HTTP_CN = "http://ns-cn.exitgames.com:80/photon/n";

		private bool retryJoinLobby;

		private byte fallbackThreadId;

		private bool didSendAcks;

		private int deltaSinceStartedToAck;

		private int startedAckingTimestamp;

		public int KeepAliveInBackground;

		private string _regionCacheSummary;

		private readonly RaiseEventOptions _cachedOptions;

		private readonly SendOptions _cachedSendOptions;

		public int CurrentMasterId => 0;

		public List<RoomInfo> RoomInfoList
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public PhotonClient(string appId)
		{
		}

		public bool Connect(PhotonRegion region, Action<bool> result)
		{
			return false;
		}

		public void ClearRoomInfo()
		{
		}

		public void JoinLobby()
		{
		}

		public void Disable()
		{
		}

		public void Update()
		{
		}

		public void StartFallbackSendAckThread()
		{
		}

		public void StopFallbackSendAckThread()
		{
		}

		public bool RealtimeFallbackThread()
		{
			return false;
		}

		public void OnConnected()
		{
		}

		public void OnConnectedToMaster()
		{
		}

		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		public void OnDisconnected(DisconnectCause cause)
		{
		}

		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		public void OnJoinedLobby()
		{
		}

		public void OnLeftLobby()
		{
		}

		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		public void OnMasterClientSwitched(Player newMasterClient)
		{
		}

		public void OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		public void OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
		{
		}

		public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
		{
		}

		public void OnCreatedRoom()
		{
		}

		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		public void OnJoinedRoom()
		{
		}

		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		public void OnLeftRoom()
		{
		}

		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		public int LocalPlayerID()
		{
			return 0;
		}

		public bool LocalPlayerIsMasterClient()
		{
			return false;
		}

		public void CallOpRaiseEvent(int targetPlayer, byte messageCode, string message)
		{
		}

		public void OnPunchFailed(int remotePlayerID)
		{
		}

		public void OnPunchSuccess(int remotePlayerID, UdpEndPoint remoteEndPoint)
		{
		}

		public override void OnEvent(EventData photonEvent)
		{
		}
	}
}
