using System.Runtime.CompilerServices;
using UdpKit;

public class NullSocket : UdpPlatformSocket
{
	private NullPlatform platform;

	internal override bool Broadcast
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	internal override UdpEndPoint EndPoint => default(UdpEndPoint);

	internal override string Error => null;

	internal override bool IsBound => false;

	internal override UdpPlatform Platform => null;

	public NullSocket(NullPlatform p)
	{
	}

	internal override void Bind(UdpEndPoint ep)
	{
	}

	internal override void Close()
	{
	}

	internal override int RecvFrom(byte[] buffer, int bufferSize, ref UdpEndPoint remoteEndpoint)
	{
		return 0;
	}

	internal override bool RecvPoll(int timeout)
	{
		return false;
	}

	internal override bool RecvPoll()
	{
		return false;
	}

	internal override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
	{
		return 0;
	}
}
