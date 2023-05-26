using System.Collections.Generic;

namespace Photon.Realtime
{
	internal class LobbyCallbacksContainer : List<ILobbyCallbacks>, ILobbyCallbacks
	{
		private HashSet<ILobbyCallbacks> targetsToAdd;

		private HashSet<ILobbyCallbacks> targetsToRemove;

		public LobbyCallbacksContainer()
		{
			((List<T>)(object)this)._002Ector();
		}

		public void AddCallbackTarget(ILobbyCallbacks target)
		{
		}

		public void RemoveCallbackTarget(ILobbyCallbacks target)
		{
		}

		private void UpdateCallbackTargets()
		{
		}

		public void OnJoinedLobby()
		{
		}

		public void OnLeftLobby()
		{
		}

		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}
	}
}
