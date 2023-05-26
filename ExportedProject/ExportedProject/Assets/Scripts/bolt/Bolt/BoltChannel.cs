namespace Bolt
{
	internal abstract class BoltChannel
	{
		private BoltConnection _cn;

		public BoltConnection connection
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public abstract void Pack(Packet packet);

		public abstract void Read(Packet packet);

		public virtual void Lost(Packet packet)
		{
		}

		public virtual void Delivered(Packet packet)
		{
		}

		public virtual void Disconnected()
		{
		}
	}
}
