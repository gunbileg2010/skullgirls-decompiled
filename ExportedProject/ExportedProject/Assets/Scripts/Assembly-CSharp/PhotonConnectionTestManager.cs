using System.Collections;
using UnityEngine;

public class PhotonConnectionTestManager : MonoBehaviour
{
	[SerializeField]
	private SyncPvpEventData debugEventForMatchmaking;

	[SerializeField]
	private int debugTeamFSForMatchmaking;

	[SerializeField]
	private string debugRoomCode;

	private Coroutine inProgressTest;

	private PhotonRealtimeService photon;

	private bool photonOpponentFound;

	public bool _buttonBackingVariable;

	public bool _HostTestButtonBackingVariable;

	public bool _JoinTestButtonBackingVariable;

	public bool _Experiment;

	public void StartMatchmakingTest()
	{
	}

	public void StartHostTest()
	{
	}

	public void StartJoinTest()
	{
	}

	public void NetworkExperiment()
	{
	}

	private IEnumerator FindOpponentConnectionTest()
	{
		return null;
	}

	private IEnumerator StartHostConnectionTest()
	{
		return null;
	}

	private IEnumerator StartJoinConnectionTest()
	{
		return null;
	}

	private IEnumerator OpenNATExperiment()
	{
		return null;
	}

	private void ListenThread()
	{
	}
}
