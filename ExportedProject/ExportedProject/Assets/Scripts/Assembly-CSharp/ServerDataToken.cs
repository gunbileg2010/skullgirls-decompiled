using Bolt;
using UdpKit;

public class ServerDataToken : ClientDataToken, IProtocolToken
{
	public string stageName;

	public int randomSeed;

	public ServerDataToken()
	{
	}

	public ServerDataToken(string playerName, string stageName, int randomSeed)
	{
	}

	public override void Read(UdpPacket packet)
	{
	}

	public override void Write(UdpPacket packet)
	{
	}
}
