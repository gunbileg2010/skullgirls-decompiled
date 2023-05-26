using Bolt;
using UdpKit;

public class ClientDataToken : IProtocolToken
{
	public string playerName;

	public ClientDataToken()
	{
	}

	public ClientDataToken(string playerName)
	{
	}

	public virtual void Read(UdpPacket packet)
	{
	}

	public virtual void Write(UdpPacket packet)
	{
	}
}
