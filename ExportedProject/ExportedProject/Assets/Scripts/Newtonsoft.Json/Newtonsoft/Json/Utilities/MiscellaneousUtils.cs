using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class MiscellaneousUtils
	{
		public static bool ValueEquals(object objA, object objB)
		{
			return false;
		}

		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return 0;
		}

		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			prefix = null;
			localName = null;
		}

		internal static string FormatValueForPrint(object value)
		{
			return null;
		}
	}
}
