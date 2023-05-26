using System.Runtime.CompilerServices;
using System.Threading;

namespace ExitGames.Client.Photon
{
	public class NetworkSimulationSet
	{
		private bool isSimulationEnabled;

		private int outgoingLag;

		private int outgoingJitter;

		private int outgoingLossPercentage;

		private int incomingLag;

		private int incomingJitter;

		private int incomingLossPercentage;

		internal PeerBase peerBase;

		private Thread netSimThread;

		public readonly ManualResetEvent NetSimManualResetEvent;

		protected internal bool IsSimulationEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int OutgoingLag => 0;

		public int OutgoingJitter => 0;

		public int OutgoingLossPercentage => 0;

		public int IncomingLag => 0;

		public int IncomingJitter => 0;

		public int IncomingLossPercentage => 0;

		public int LostPackagesOut
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

		public int LostPackagesIn
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

		public override string ToString()
		{
			return null;
		}
	}
}
