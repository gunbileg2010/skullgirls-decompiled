using System;
using BoltInternal;
using Photon.Realtime;
using UdpKit;
using udpkit.platform.photon;

namespace Bolt.Photon
{
	internal class PhotonCloudGlobalBehavior : udpkit.platform.photon.PhotonPoller
	{
		internal class PhotonBoltBehavior : GlobalEventListenerBase
		{
			public override void BoltStartBegin()
			{
			}

			public override void BoltStartDone()
			{
			}

			public override void BoltShutdownBegin(AddCallback registerDoneCallback)
			{
			}

			public override void Connected(BoltConnection connection)
			{
			}

			public override void ConnectFailed(UdpEndPoint endpoint, IProtocolToken token)
			{
			}

			public override void ConnectRefused(UdpEndPoint endpoint, IProtocolToken token)
			{
			}
		}

		private void Awake()
		{
		}

		protected internal override void BoltConnectInternal(UdpEndPoint endPoint, object token)
		{
		}

		protected internal override void BoltDisconnectInternal(DisconnectCause disconnectedCause)
		{
		}

		protected internal override UdpEndPoint BoltEndPointInternal()
		{
			return default(UdpEndPoint);
		}

		protected internal override bool BoltIsClientInternal()
		{
			return false;
		}

		protected internal override void BoltUpdateSessionListInternal(Map<Guid, UdpSession> sessions)
		{
		}

		private UdpConnectionDisconnectReason ConvertDisconnectReason(DisconnectCause disconnectedCause)
		{
			return default(UdpConnectionDisconnectReason);
		}
	}
}
