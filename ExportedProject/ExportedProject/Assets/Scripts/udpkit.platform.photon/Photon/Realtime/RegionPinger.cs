using System;
using System.Runtime.CompilerServices;

namespace Photon.Realtime
{
	public class RegionPinger
	{
		public static int Attempts;

		public static bool IgnoreInitialAttempt;

		public static int MaxMilliseconsPerPing;

		public static int PingWhenFailed;

		private Region region;

		private string regionAddress;

		public int CurrentAttempt;

		private Action<Region> onDoneCall;

		private PhotonPing ping;

		public bool Done
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

		public RegionPinger(Region region, Action<Region> onDoneCallback)
		{
		}

		private PhotonPing GetPingImplementation()
		{
			return null;
		}

		public bool Start()
		{
			return false;
		}

		protected internal bool RegionPingThreaded()
		{
			return false;
		}

		public static string ResolveHost(string hostName)
		{
			return null;
		}
	}
}
