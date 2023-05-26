using System.Collections.Generic;

namespace Photon.Realtime
{
	public class MatchMakingCallbacksContainer : List<IMatchmakingCallbacks>, IMatchmakingCallbacks
	{
		private HashSet<IMatchmakingCallbacks> targetsToAdd;

		private HashSet<IMatchmakingCallbacks> targetsToRemove;

		public MatchMakingCallbacksContainer()
		{
			((List<T>)(object)this)._002Ector();
		}

		public void AddCallbackTarget(IMatchmakingCallbacks target)
		{
		}

		public void RemoveCallbackTarget(IMatchmakingCallbacks target)
		{
		}

		private void UpdateCallbackTargets()
		{
		}

		public void OnCreatedRoom()
		{
		}

		public void OnJoinedRoom()
		{
		}

		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		public void OnLeftRoom()
		{
		}

		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}
	}
}
