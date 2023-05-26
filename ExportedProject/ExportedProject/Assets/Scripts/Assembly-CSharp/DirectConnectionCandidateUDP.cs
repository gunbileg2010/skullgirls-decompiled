using System;
using System.Text;
using UdpKit;

public class DirectConnectionCandidateUDP : DirectConnectionCandidateBase
{
	public struct AddressPortPair
	{
		public string address;

		public int port;

		public AddressPortPair(string address, int port)
		{
		}
	}

	private bool isPrivateConnection;

	private string myIP;

	private int myPort;

	private int myPingMs;

	private string opponentIP;

	private int opponentPort;

	private int opponentPing;

	private bool isHost;

	private byte keyByte;

	private bool isCleaningUp;

	private AddressPortPair[] stunServers;

	private OpenNATProtocol openNATProtocol;

	public DirectConnectionCandidateUDP()
	{
	}

	public DirectConnectionCandidateUDP(bool useLocalConnection)
	{
	}

	public override void Init(bool isHost, Action initCompleteCallback)
	{
	}

	public override void WriteInfoForOpponent(UdpPacket packet)
	{
	}

	public override void ReadInfoFromOpponent(UdpPacket packet)
	{
	}

	public override void DiscoverAndMeasureConnections(Action discoveryCompleteCallback)
	{
	}

	public override void Cleanup()
	{
	}

	public override bool IsAvailableToPlayer()
	{
		return false;
	}

	public int GetListenPort()
	{
		return 0;
	}

	public string GetOpponentIP()
	{
		return null;
	}

	public int GetOpponentPort()
	{
		return 0;
	}

	public override void LogStatusToStringBuilder(StringBuilder stringBuilder)
	{
	}

	public override int GetMyPingMs()
	{
		return 0;
	}

	public override void SetOpponentPingMs(int value)
	{
	}

	public override int GetOpponentPingMs()
	{
		return 0;
	}

	private void AttemptStunRecursion(int stunAddressIndex, Action<bool> callback)
	{
	}

	private void ProcessSTUNSuccess(StunProtocol stun, Action<bool> callback)
	{
	}
}
