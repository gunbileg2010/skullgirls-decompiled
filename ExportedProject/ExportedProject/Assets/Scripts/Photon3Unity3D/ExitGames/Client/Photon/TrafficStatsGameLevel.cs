using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class TrafficStatsGameLevel
	{
		private int timeOfLastDispatchCall;

		private int timeOfLastSendCall;

		public int OperationByteCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int OperationCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int ResultByteCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int ResultCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int EventByteCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int EventCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LongestOpResponseCallback
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public byte LongestOpResponseCallbackOpCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LongestEventCallback
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LongestMessageCallback
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LongestRawMessageCallback
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public byte LongestEventCallbackCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LongestDeltaBetweenDispatching
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int LongestDeltaBetweenSending
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int DispatchIncomingCommandsCalls
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int SendOutgoingCommandsCalls
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal void CountOperation(int operationBytes)
		{
		}

		internal void CountResult(int resultBytes)
		{
		}

		internal void CountEvent(int eventBytes)
		{
		}

		internal void TimeForResponseCallback(byte code, int time)
		{
		}

		internal void TimeForEventCallback(byte code, int time)
		{
		}

		internal void TimeForMessageCallback(int time)
		{
		}

		internal void TimeForRawMessageCallback(int time)
		{
		}

		internal void DispatchIncomingCommandsCalled()
		{
		}

		internal void SendOutgoingCommandsCalled()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToStringVitalStats()
		{
			return null;
		}
	}
}
