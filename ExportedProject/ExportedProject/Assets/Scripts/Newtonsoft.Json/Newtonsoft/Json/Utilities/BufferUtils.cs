using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class BufferUtils
	{
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize)
		{
			return null;
		}

		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
		}

		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			return null;
		}
	}
}
