using System.Collections.Generic;

namespace Bolt
{
	internal struct EventUnreliable
	{
		internal class PriorityComparer : IComparer<EventUnreliable>
		{
			public static readonly PriorityComparer Instance;

			private PriorityComparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CBolt_002EEventUnreliable_003E_002ECompare(EventUnreliable x, EventUnreliable y)
			{
				return 0;
			}
		}

		public bool Skipped;

		public Event NetworkEvent;

		public float Priority;

		public static EventUnreliable Wrap(Event ev)
		{
			return default(EventUnreliable);
		}
	}
}
