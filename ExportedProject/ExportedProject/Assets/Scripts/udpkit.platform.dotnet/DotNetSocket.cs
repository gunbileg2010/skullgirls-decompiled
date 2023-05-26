using System.Net;
using System.Net.Sockets;
using UdpKit;

internal class DotNetSocket : UdpPlatformSocket
{
	private string error;

	protected Socket socket;

	private readonly DotNetPlatform platform;

	protected EndPoint recvEndPoint;

	protected UdpEndPoint endpoint;

	internal override UdpPlatform Platform => null;

	internal override string Error => null;

	internal override bool IsBound => false;

	internal override UdpEndPoint EndPoint => default(UdpEndPoint);

	internal override bool Broadcast
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DotNetSocket(DotNetPlatform platform, bool ipv6)
	{
	}

	internal override void Close()
	{
	}

	internal override void Bind(UdpEndPoint ep)
	{
	}

	internal override bool RecvPoll()
	{
		return false;
	}

	internal override bool RecvPoll(int timeout)
	{
		return false;
	}

	internal override int RecvFrom(byte[] buffer, int bufferSize, ref UdpEndPoint remoteEndpoint)
	{
		return 0;
	}

	internal override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
	{
		return 0;
	}

	private void HandleSocketException(SocketException exn)
	{
	}

	private void VerifyIsBound()
	{
	}
}
