using System.Runtime.CompilerServices;
using UdpKit;

namespace Bolt
{
	[Documentation]
	public abstract class Command : NetworkObj_Root, IBoltListNode<Command>
	{
		internal const int SEQ_BITS = 8;

		internal const int SEQ_SHIFT = 8;

		internal const int SEQ_MASK = 255;

		private NetworkStorage storage;

		internal new Command_Meta Meta;

		internal int SmoothFrameFrom;

		internal int SmoothFrameTo;

		internal NetworkStorage SmoothStorageFrom;

		internal NetworkStorage SmoothStorageTo;

		internal ushort Sequence;

		internal CommandFlags Flags;

		private bool shouldDeltaCompressInput;

		private bool shouldDeltaCompressResult;

		internal override NetworkStorage Storage => null;

		internal NetworkCommand_Data InputObject => null;

		internal NetworkCommand_Data ResultObject => null;

		internal bool AssignedInputDeltaCompression
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal bool AssignedResultDeltaCompression
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal bool ShouldDeltaCompressInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool ShouldDeltaCompressResult
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int ServerFrame
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public bool IsFirstExecution => false;

		public object UserToken
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

		private Command IBoltListNode_003CBolt_002ECommand_003E_002Eprev
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

		private Command IBoltListNode_003CBolt_002ECommand_003E_002Enext
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

		private object IBoltListNode_003CBolt_002ECommand_003E_002Elist
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

		internal Command(Command_Meta meta)
			: base(null)
		{
		}

		internal void InitNetworkStorage()
		{
		}

		internal void VerifyCanSetInput()
		{
		}

		internal void VerifyCanSetResult()
		{
		}

		internal void PackInput(BoltConnection connection, UdpPacket packet)
		{
		}

		internal void PackInputDiff(BoltConnection connection, UdpPacket packet, NetworkStorage other)
		{
		}

		internal void ReadInput(BoltConnection connection, UdpPacket packet)
		{
		}

		internal void ReadInputDiff(BoltConnection connection, UdpPacket packet, NetworkStorage other)
		{
		}

		internal void PackResult(BoltConnection connection, UdpPacket packet)
		{
		}

		internal void PackResultDiff(BoltConnection connection, UdpPacket packet, NetworkStorage other)
		{
		}

		internal void ReadResult(BoltConnection connection, UdpPacket packet)
		{
		}

		internal void ReadResultDiff(BoltConnection connection, UdpPacket packet, NetworkStorage other)
		{
		}

		internal int GetDiffDistance(NetworkCommand_Data data, NetworkStorage other)
		{
			return 0;
		}

		internal void BeginSmoothing()
		{
		}

		internal void SmoothCorrection()
		{
		}

		internal void Free()
		{
		}

		private static void ReadDiff(BoltConnection connection, UdpPacket packet, NetworkCommand_Data data, NetworkStorage storage, NetworkStorage smoothStorage, NetworkStorage other)
		{
		}

		private static void PackDiff(BoltConnection connection, UdpPacket packet, NetworkCommand_Data data, NetworkStorage storage, NetworkStorage other)
		{
		}

		public static implicit operator bool(Command cmd)
		{
			return false;
		}
	}
}
