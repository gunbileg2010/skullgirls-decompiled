using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class TrafficStats
	{
		public int PackageHeaderSize
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

		public int ReliableCommandCount
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

		public int UnreliableCommandCount
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

		public int FragmentCommandCount
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

		public int ControlCommandCount
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

		public int TotalPacketCount
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

		public int TotalCommandsInPackets
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

		public int ReliableCommandBytes
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

		public int UnreliableCommandBytes
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

		public int FragmentCommandBytes
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

		public int ControlCommandBytes
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

		public int TotalCommandBytes => 0;

		public int TotalPacketBytes => 0;

		public int TimestampOfLastAck
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public int TimestampOfLastReliableCommand
		{
			[CompilerGenerated]
			set
			{
			}
		}

		internal TrafficStats(int packageHeaderSize)
		{
		}

		internal void CountControlCommand(int size)
		{
		}

		internal void CountReliableOpCommand(int size)
		{
		}

		internal void CountUnreliableOpCommand(int size)
		{
		}

		internal void CountFragmentOpCommand(int size)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
