using System;

namespace Photon.Realtime
{
	public class RaiseEventOptions
	{
		public static readonly RaiseEventOptions Default;

		public EventCaching CachingOption;

		public byte InterestGroup;

		public int[] TargetActors;

		public ReceiverGroup Receivers;

		[Obsolete]
		public byte SequenceChannel;

		public WebFlags Flags;
	}
}
