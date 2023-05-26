using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class StringReferenceExtensions
	{
		public static int IndexOf(this StringReference s, char c, int startIndex, int length)
		{
			return 0;
		}

		public static bool StartsWith(this StringReference s, string text)
		{
			return false;
		}

		public static bool EndsWith(this StringReference s, string text)
		{
			return false;
		}
	}
}
