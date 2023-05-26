namespace PubNubAPI
{
	public sealed class Counter
	{
		private uint current;

		private readonly object syncRoot;

		public uint NextValue()
		{
			return 0u;
		}

		public void Reset()
		{
		}
	}
}
