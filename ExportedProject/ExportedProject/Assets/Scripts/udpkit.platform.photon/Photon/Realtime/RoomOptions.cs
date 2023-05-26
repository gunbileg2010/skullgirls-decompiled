using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class RoomOptions
	{
		private bool isVisible;

		private bool isOpen;

		public byte MaxPlayers;

		public int PlayerTtl;

		public int EmptyRoomTtl;

		private bool cleanupCacheOnLeave;

		public Hashtable CustomRoomProperties;

		public string[] CustomRoomPropertiesForLobby;

		public string[] Plugins;

		private bool broadcastPropsChangeToAll;

		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CleanupCacheOnLeave => false;

		public bool SuppressRoomEvents
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool PublishUserId
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool DeleteNullProperties
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool BroadcastPropsChangeToAll => false;
	}
}
