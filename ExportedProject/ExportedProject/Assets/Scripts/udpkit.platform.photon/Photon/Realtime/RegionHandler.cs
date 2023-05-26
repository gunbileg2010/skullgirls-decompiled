using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class RegionHandler
	{
		private string availableRegionCodes;

		private Region bestRegionCache;

		private List<RegionPinger> pingerList;

		private Action<RegionHandler> onCompleteCall;

		private int previousPing;

		public List<Region> EnabledRegions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		public Region BestRegion => null;

		public string SummaryToCache => null;

		public bool IsPinging
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

		public void SetRegions(OperationResponse opGetRegions)
		{
		}

		public bool PingMinimumOfRegions(Action<RegionHandler> onCompleteCallback, string previousSummary)
		{
			return false;
		}

		private void OnPreferredRegionPinged(Region preferredRegion)
		{
		}

		private bool PingEnabledRegions()
		{
			return false;
		}

		private void OnRegionDone(Region region)
		{
		}
	}
}
