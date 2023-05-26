using System.Collections.Generic;

namespace Photon.Realtime
{
	public class ConnectionCallbacksContainer : List<IConnectionCallbacks>, IConnectionCallbacks
	{
		private HashSet<IConnectionCallbacks> targetsToAdd;

		private HashSet<IConnectionCallbacks> targetsToRemove;

		public ConnectionCallbacksContainer()
		{
			((List<T>)(object)this)._002Ector();
		}

		public void AddCallbackTarget(IConnectionCallbacks target)
		{
		}

		public void RemoveCallbackTarget(IConnectionCallbacks target)
		{
		}

		private void UpdateCallbackTargets()
		{
		}

		public void OnConnected()
		{
		}

		public void OnConnectedToMaster()
		{
		}

		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		public void OnDisconnected(DisconnectCause cause)
		{
		}

		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}
	}
}
