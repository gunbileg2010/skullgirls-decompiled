using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class Room : RoomInfo
	{
		private bool isOffline;

		private Dictionary<int, Player> players;

		public LoadBalancingClient LoadBalancingClient
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

		public new string Name => null;

		public bool IsOffline => false;

		public new bool IsOpen
		{
			set
			{
			}
		}

		public new bool IsVisible
		{
			set
			{
			}
		}

		public new byte PlayerCount => 0;

		public Dictionary<int, Player> Players => null;

		public int MasterClientId => 0;

		public Room(string roomName, RoomOptions options, bool isOffline = false)
			: base(null, null)
		{
		}

		protected internal override void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}

		public virtual void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
		}

		protected internal virtual void RemovePlayer(Player player)
		{
		}

		protected internal virtual void RemovePlayer(int id)
		{
		}

		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
