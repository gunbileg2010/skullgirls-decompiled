using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon.EncryptorManaged;

namespace ExitGames.Client.Photon
{
	public class PhotonPeer
	{
		[Obsolete]
		public int WarningSize;

		public const bool NoSocket = false;

		public const bool NativeDatagramEncrypt = false;

		public const bool DebugBuild = true;

		protected internal byte ClientSdkId;

		private string clientVersion;

		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig;

		public DebugLevel DebugOut;

		private byte quickResendAttempts;

		public int RhttpMinConnections;

		public int RhttpMaxConnections;

		public byte ChannelCount;

		private bool crcEnabled;

		public int SentCountAllowance;

		public int TimePingInterval;

		public int DisconnectTimeout;

		public static int OutgoingStreamBufferSize;

		private int mtu;

		public static bool AsyncKeyExchange;

		internal bool RandomizeSequenceNumbers;

		internal byte[] RandomizedSequenceNumbers;

		private Stopwatch trafficStatsStopwatch;

		private bool trafficStatsEnabled;

		internal PeerBase peerBase;

		private readonly object SendOutgoingLockObject;

		private readonly object DispatchLockObject;

		private readonly object EnqueueLock;

		protected internal byte[] PayloadEncryptionSecret;

		internal Encryptor DgramEncryptor;

		internal Decryptor DgramDecryptor;

		protected internal byte ClientSdkIdShifted => 0;

		public string ClientVersion => null;

		public SerializationProtocol SerializationProtocolType
		{
			[CompilerGenerated]
			get
			{
				return default(SerializationProtocol);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Type SocketImplementation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public IPhotonPeerListener Listener
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

		public bool EnableServerTracing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public byte QuickResendAttempts => 0;

		public PeerStateValue PeerState => default(PeerStateValue);

		public string PeerID => null;

		public bool CrcEnabled => false;

		public int ConnectionTime => 0;

		public int LastSendOutgoingTime => 0;

		public int RoundTripTime => 0;

		public int RoundTripTimeVariance => 0;

		public int TimestampOfLastSocketReceive => 0;

		public string ServerAddress => null;

		public string ServerIpAddress => null;

		public ConnectionProtocol TransportProtocol
		{
			[CompilerGenerated]
			get
			{
				return default(ConnectionProtocol);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int MaximumTransferUnit => 0;

		public bool IsEncryptionAvailable => false;

		public bool IsSendingOnlyAcks
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public TrafficStats TrafficStatsIncoming
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public TrafficStats TrafficStatsOutgoing
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public TrafficStatsGameLevel TrafficStatsGameLevel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public long TrafficStatsElapsedMs => 0L;

		public bool TrafficStatsEnabled => false;

		internal void InitializeTrafficStats()
		{
		}

		public string VitalStatsToString(bool all)
		{
			return null;
		}

		public PhotonPeer(ConnectionProtocol protocolType)
		{
		}

		public virtual bool Connect(string serverAddress, string applicationName, object custom)
		{
			return false;
		}

		private void CreatePeerBase()
		{
		}

		public virtual void Disconnect()
		{
		}

		public virtual void StopThread()
		{
		}

		public bool EstablishEncryption()
		{
			return false;
		}

		public bool InitDatagramEncryption(byte[] encryptionSecret, byte[] hmacSecret, bool randomizedSequenceNumbers = false)
		{
			return false;
		}

		public void InitPayloadEncryption(byte[] secret)
		{
		}

		public virtual void Service()
		{
		}

		public virtual bool SendOutgoingCommands()
		{
			return false;
		}

		public virtual bool SendAcksOnly()
		{
			return false;
		}

		public virtual bool DispatchIncomingCommands()
		{
			return false;
		}

		public virtual bool SendOperation(byte operationCode, Dictionary<byte, object> operationParameters, SendOptions sendOptions)
		{
			return false;
		}
	}
}
