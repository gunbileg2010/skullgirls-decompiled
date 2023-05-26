using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UdpKit;
using udpkit.platform.photon;

namespace Bolt.Photon
{
	public sealed class PhotonRoomProperties : IProtocolToken, udpkit.platform.photon.IPhotonRoomPropertiesInternal
	{
		private Hashtable _CustomRoomProperties;

		private readonly HashSet<string> _CustomRoomPropertiesInLobby;

		public bool IsOpen
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsVisible
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Hashtable udpkit_002Eplatform_002Ephoton_002EIPhotonRoomPropertiesInternal_002ECustomRoomProperties => null;

		private HashSet<string> udpkit_002Eplatform_002Ephoton_002EIPhotonRoomPropertiesInternal_002ECustomRoomPropertiesInLobby => null;

		public bool AddRoomProperty(string key, object value, bool showInLobby = true)
		{
			return false;
		}

		public bool RemoveRoomProperty(string key)
		{
			return false;
		}

		public void Write(UdpPacket packet)
		{
		}

		public void Read(UdpPacket packet)
		{
		}

		private bool IsValid(object value)
		{
			return false;
		}
	}
}
