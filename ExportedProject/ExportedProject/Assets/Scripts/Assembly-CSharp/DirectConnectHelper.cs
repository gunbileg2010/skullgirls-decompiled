using System;
using System.Collections.Generic;
using UdpKit;

[Serializable]
public class DirectConnectHelper
{
	private List<DirectConnectionCandidateBase> directConnectionCandidates;

	private bool isCleaningUp;

	public DirectConnectHelper(bool isHost, Action initFinishedCallback)
	{
	}

	public void WriteDataForOpponent(UdpPacket packet)
	{
	}

	public void ReadDataFromOpponent(UdpPacket packet)
	{
	}

	public void DiscoverAndMeasureConnections(Action discoveryCompleteCallback)
	{
	}

	public bool IsInitFinished()
	{
		return false;
	}

	public bool IsConnectionDiscoveryComplete()
	{
		return false;
	}

	public void Cleanup()
	{
	}

	public void WriteConnectionResultData(UdpPacket packet)
	{
	}

	public void WriteConnectionPreferenceData(UdpPacket packet)
	{
	}

	public void ReadConnectionResultDataFromOpponent(UdpPacket packet)
	{
	}

	public bool IsDirectUDPConnectionPossible()
	{
		return false;
	}

	public int GetUDPListenPort()
	{
		return 0;
	}

	public string GetUDPOpponentIP()
	{
		return null;
	}

	public int GetUDPOpponentPort()
	{
		return 0;
	}

	public void GetFavoredConnectionsPingsMs(out int myPingMs, out int opponentPingMs)
	{
		myPingMs = default(int);
		opponentPingMs = default(int);
	}

	public void LogCurrentStatusToConsole(string context)
	{
	}

	public string GetDebugConsoleConnectionStatus()
	{
		return null;
	}
}
