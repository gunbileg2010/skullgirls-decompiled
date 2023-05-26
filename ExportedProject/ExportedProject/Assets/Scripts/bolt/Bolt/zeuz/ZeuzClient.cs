using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

namespace Bolt.zeuz
{
	public class ZeuzClient : LoadBalancingClient
	{
		public static readonly string ROOM_PROPERTY_GROUP_ID;

		public static readonly string ROOM_PROPERTY_PROFILE_ID;

		public static readonly string ROOM_PROPERTY_MIN_PLAYERS;

		public static readonly string ROOM_PROPERTY_CUSTOM_SERVER_IP;

		public static readonly string ROOM_PROPERTY_CUSTOM_SERVER_PORT;

		private const byte EVENT_CODE_SERVER_INFO = 198;

		private const byte EVENT_CODE_SERVER_NOT_AVAILABLE = 199;

		private const int MIN_PLAYERS_UNDEFINED = -1;

		public event Action<string, int> OnServerInfoReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnServerNotAvailable
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public RoomOptions GetRoomOptions(int groupID, int profileID)
		{
			return null;
		}

		public RoomOptions GetRoomOptions(int groupID, int profileID, int minPlayers)
		{
			return null;
		}

		public RoomOptions GetRoomOptions(int groupID, int profileID, string customServerIP, int customServerPort)
		{
			return null;
		}

		public RoomOptions GetRoomOptions(int groupID, int profileID, int minPlayers, string customServerIP, int customServerPort)
		{
			return null;
		}

		public Hashtable GetRoomProperties(int groupID, int profileID)
		{
			return null;
		}

		public Hashtable GetRoomProperties(int groupID, int profileID, int minPlayers)
		{
			return null;
		}

		public Hashtable GetRoomProperties(int groupID, int profileID, string customServerIP, int customServerPort)
		{
			return null;
		}

		public Hashtable GetRoomProperties(int groupID, int profileID, int minPlayers, string customServerIP, int customServerPort)
		{
			return null;
		}

		public string[] GetRoomPropertiesForLobby()
		{
			return null;
		}

		public override void OnEvent(EventData photonEvent)
		{
		}
	}
}
