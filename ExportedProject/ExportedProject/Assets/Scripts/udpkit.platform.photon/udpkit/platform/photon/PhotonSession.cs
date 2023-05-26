using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UdpKit;

namespace udpkit.platform.photon
{
	public class PhotonSession : UdpSession
	{
		internal Guid _id;

		internal int _playerCount;

		internal int _playerLimit;

		internal string _roomName;

		internal byte[] _hostData;

		internal Hashtable _customProperties;

		internal bool _IsVisible;

		internal bool _IsOpen;

		public override int ConnectionsCurrent => 0;

		public override int ConnectionsMax => 0;

		public override bool HasLan => false;

		public override bool HasWan => false;

		public override string HostName => null;

		public override Guid Id => default(Guid);

		public override bool IsDedicatedServer => false;

		public override UdpEndPoint LanEndPoint => default(UdpEndPoint);

		public override UdpSessionSource Source => default(UdpSessionSource);

		public override UdpEndPoint WanEndPoint => default(UdpEndPoint);

		public override byte[] HostData => null;

		public override object HostObject
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

		internal PhotonSession()
		{
		}

		public override UdpSession Clone()
		{
			return null;
		}
	}
}
