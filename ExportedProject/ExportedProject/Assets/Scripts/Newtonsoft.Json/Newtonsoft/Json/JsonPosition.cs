using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	internal struct JsonPosition
	{
		private static readonly char[] SpecialCharacters;

		internal JsonContainerType Type;

		internal int Position;

		internal string PropertyName;

		internal bool HasIndex;

		public JsonPosition(JsonContainerType type)
		{
		}

		internal int CalculateLength()
		{
			return 0;
		}

		internal void WriteTo(StringBuilder sb)
		{
		}

		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return false;
		}

		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}
	}
}
