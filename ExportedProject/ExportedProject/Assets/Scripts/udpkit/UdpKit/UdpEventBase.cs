namespace UdpKit
{
	public abstract class UdpEventBase
	{
		public abstract int Type { get; }

		public static implicit operator UdpEvent(UdpEventBase ev)
		{
			return default(UdpEvent);
		}
	}
}
