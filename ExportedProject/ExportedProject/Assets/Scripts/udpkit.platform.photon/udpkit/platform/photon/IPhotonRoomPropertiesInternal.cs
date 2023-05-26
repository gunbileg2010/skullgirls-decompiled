using System.Collections.Generic;
using ExitGames.Client.Photon;

namespace udpkit.platform.photon
{
	internal interface IPhotonRoomPropertiesInternal
	{
		bool IsOpen { get; }

		bool IsVisible { get; }

		Hashtable CustomRoomProperties { get; }

		HashSet<string> CustomRoomPropertiesInLobby { get; }
	}
}
