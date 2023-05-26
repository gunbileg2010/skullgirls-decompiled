using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class RoomInfo
	{
		public bool RemovedFromList;

		private Hashtable customProperties;

		protected byte maxPlayers;

		protected int emptyRoomTtl;

		protected int playerTtl;

		protected string[] expectedUsers;

		protected bool isOpen;

		protected bool isVisible;

		protected bool autoCleanUp;

		protected string name;

		public int masterClientId;

		protected string[] propertiesListedInLobby;

		public Hashtable CustomProperties => null;

		public string Name => null;

		public int PlayerCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte MaxPlayers => 0;

		public bool IsOpen => false;

		public bool IsVisible => false;

		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
}
