namespace Bolt
{
	internal struct EventReliable
	{
		public Event NetworkEvent;

		public uint Sequence;

		public static EventReliable Wrap(Event ev)
		{
			return default(EventReliable);
		}

		public static EventReliable Wrap(Event ev, uint sequence)
		{
			return default(EventReliable);
		}
	}
}
