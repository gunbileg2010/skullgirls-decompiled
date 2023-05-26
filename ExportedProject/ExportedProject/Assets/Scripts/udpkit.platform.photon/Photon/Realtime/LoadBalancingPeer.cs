using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class LoadBalancingPeer : PhotonPeer
	{
		protected internal static Type PingImplementation;

		private readonly Dictionary<byte, object> opParameters;

		public LoadBalancingPeer(ConnectionProtocol protocolType)
			: base(default(ConnectionProtocol))
		{
		}

		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
			: base(default(ConnectionProtocol))
		{
		}

		private void ConfigUnitySockets()
		{
		}

		public virtual bool OpGetRegions(string appId)
		{
			return false;
		}

		public virtual bool OpJoinLobby(TypedLobby lobby = null)
		{
			return false;
		}

		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return false;
		}

		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return false;
		}

		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return false;
		}

		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return false;
		}

		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webflags = null)
		{
			return false;
		}

		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webflags = null)
		{
			return false;
		}

		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return false;
		}

		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return false;
		}

		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return false;
		}

		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return false;
		}
	}
}
