using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class JsonTokenUtils
	{
		internal static bool IsEndToken(JsonToken token)
		{
			return false;
		}

		internal static bool IsStartToken(JsonToken token)
		{
			return false;
		}

		internal static bool IsPrimitiveToken(JsonToken token)
		{
			return false;
		}
	}
}
