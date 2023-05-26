using System.Collections.Generic;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	internal class InRoomCallbacksContainer : List<IInRoomCallbacks>, IInRoomCallbacks
	{
		private HashSet<IInRoomCallbacks> targetsToAdd;

		private HashSet<IInRoomCallbacks> targetsToRemove;

		public InRoomCallbacksContainer()
		{
			((List<T>)(object)this)._002Ector();
		}

		public void AddCallbackTarget(IInRoomCallbacks target)
		{
		}

		public void RemoveCallbackTarget(IInRoomCallbacks target)
		{
		}

		private void UpdateCallbackTargets()
		{
		}

		public void OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		public void OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
		{
		}

		public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProp)
		{
		}

		public void OnMasterClientSwitched(Player newMasterClient)
		{
		}
	}
}
