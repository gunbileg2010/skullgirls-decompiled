using System.Diagnostics;
using System.Net;

namespace udpkit.plataform.photon.puncher
{
	internal class StunManager
	{
		public enum StunStatus
		{
			NOT_SENT = 1,
			WAITING = 2,
			RECEIVED = 4,
			FAIL = 8
		}

		public StunStatus status;

		private readonly int _id;

		private IPEndPoint _externalEndPoint;

		private int _connTries;

		private int _connIndex;

		private readonly Stopwatch _connStopWatch;

		private readonly Puncher _puncher;

		public IPEndPoint ExternalEndpoint => null;

		public StunManager(Puncher puncher)
		{
		}

		public void CheckStunInfo()
		{
		}

		public void RecvStunMessage(PunchMessage pm)
		{
		}

		private void RequestStunInfo()
		{
		}
	}
}
