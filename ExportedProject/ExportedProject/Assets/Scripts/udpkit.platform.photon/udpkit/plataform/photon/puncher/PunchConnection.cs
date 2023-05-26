using System.Diagnostics;
using System.Net;

namespace udpkit.plataform.photon.puncher
{
	internal class PunchConnection
	{
		public bool enabled;

		public int remoteId;

		public PunchInfo punchInfo;

		public IPEndPoint targetAddress;

		public PunchConnectionState state;

		private int _thresholdExternalAddress;

		private bool _pingSent;

		private bool _pongSent;

		private bool _pongReceived;

		private int _tries;

		private Stopwatch _stopWatch;

		public PunchConnection(int remoteId, PunchInfo punchInfo)
		{
		}

		public void CheckAddresses(PunchInfo localPunchInfo)
		{
		}

		public void MarkSend()
		{
		}

		public void MarkPongSent()
		{
		}

		public void MarkPongReceived()
		{
		}

		public bool CanSend()
		{
			return false;
		}

		private void ResetTime()
		{
		}

		private void CheckSucess()
		{
		}
	}
}
