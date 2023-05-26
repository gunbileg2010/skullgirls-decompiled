using System.Runtime.CompilerServices;

namespace UdpKit
{
	public abstract class UdpPlatformSocket
	{
		internal object Token
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal abstract string Error { get; }

		internal abstract bool IsBound { get; }

		internal abstract bool Broadcast { get; set; }

		internal abstract UdpEndPoint EndPoint { get; }

		internal abstract UdpPlatform Platform { get; }

		internal abstract void Close();

		internal abstract void Bind(UdpEndPoint ep);

		internal abstract bool RecvPoll();

		internal abstract bool RecvPoll(int timeout);

		internal abstract int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint);

		internal abstract int RecvFrom(byte[] buffer, int bufferSize, ref UdpEndPoint remoteEndpoint);

		internal int SendTo(byte[] buffer, UdpEndPoint endpoint)
		{
			return 0;
		}

		internal int RecvFrom(byte[] buffer, ref UdpEndPoint endpoint)
		{
			return 0;
		}
	}
}
