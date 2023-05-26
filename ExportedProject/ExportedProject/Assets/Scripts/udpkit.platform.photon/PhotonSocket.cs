using UdpKit;

internal class PhotonSocket : UdpPlatformSocket
{
	private bool _bound;

	private UdpEndPoint _endpoint;

	private readonly PhotonPlatform _platform;

	private readonly global::DotNetSocket _dotNetSocket;

	private readonly global::DotNetPlatform _dotNetPlatform;

	internal override UdpPlatform Platform => null;

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

	internal override UdpEndPoint EndPoint => default(UdpEndPoint);

	internal override string Error => null;

	internal override bool IsBound => false;

	public PhotonSocket(PhotonPlatform photonPlatform, global::DotNetPlatform dotPlatform)
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

	internal override bool RecvPoll()
	{
		return false;
	}

	internal override bool RecvPoll(int timeout)
	{
		return false;
	}

	internal override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
	{
		return 0;
	}
}
