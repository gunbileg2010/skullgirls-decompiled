using System.IO;
using UnityEngine;

public class GGPOSyncTest : MonoBehaviour
{
	[SerializeField]
	private GameObject p1GO;

	[SerializeField]
	private GameObject p2GO;

	private string remoteIpAddress;

	private ushort myPort;

	private ushort remotePort;

	private bool isPlayer2;

	private bool runSyncTest;

	private byte[] localInput;

	private byte[] syncInputs;

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void SimulateFrame()
	{
	}

	private void UpdateScene()
	{
	}

	private int GetSaveStateSize()
	{
		return 0;
	}

	private byte[] SaveGameState(ref int size, ref int checksum)
	{
		return null;
	}

	private void LoadGameState(BinaryReader reader)
	{
	}

	private void AdvanceFrame()
	{
	}

	private void OnGGPOEvent(GGPO.GGPOEvent eventInfo)
	{
	}
}
