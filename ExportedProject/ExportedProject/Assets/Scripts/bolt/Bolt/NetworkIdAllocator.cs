namespace Bolt
{
	internal static class NetworkIdAllocator
	{
		private static uint EntityId;

		private static uint ConnectionId;

		public static uint LocalConnectionId => 0u;

		public static void Reset(uint connectionId)
		{
		}

		public static void Assigned(uint connectionId)
		{
		}

		public static NetworkId Allocate()
		{
			return default(NetworkId);
		}
	}
}
