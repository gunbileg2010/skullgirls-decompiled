using System.Net;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public abstract class IPhotonSocket
	{
		protected internal PeerBase peerBase;

		protected readonly ConnectionProtocol Protocol;

		public bool PollReceive;

		protected IPhotonPeerListener Listener => null;

		protected internal int MTU => 0;

		public PhotonSocketState State
		{
			[CompilerGenerated]
			get
			{
				return default(PhotonSocketState);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool Connected => false;

		public string ServerAddress
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static string ServerIpAddress
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ServerPort
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool AddressResolvedAsIpv6
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		protected string UrlProtocol
		{
			[CompilerGenerated]
			set
			{
			}
		}

		protected string UrlPath
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public IPhotonSocket(PeerBase peerBase)
		{
		}

		public virtual bool Connect()
		{
			return false;
		}

		public abstract bool Disconnect();

		public abstract PhotonSocketError Send(byte[] data, int length);

		public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused)
		{
		}

		public bool ReportDebugOfLevel(DebugLevel levelOfMessage)
		{
			return false;
		}

		public void EnqueueDebugReturn(DebugLevel debugLevel, string message)
		{
		}

		protected internal void HandleException(StatusCode statusCode)
		{
		}

		protected internal bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath)
		{
			address = null;
			port = default(ushort);
			urlProtocol = null;
			urlPath = null;
			return false;
		}

		protected internal bool IsIpv6SimpleCheck(IPAddress address)
		{
			return false;
		}

		protected internal static IPAddress GetIpAddress(string address)
		{
			return null;
		}
	}
}
