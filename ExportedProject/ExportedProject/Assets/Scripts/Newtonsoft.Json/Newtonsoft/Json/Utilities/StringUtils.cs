using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class StringUtils
	{
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			return null;
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			return null;
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		private static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			return null;
		}

		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		public static int? GetLength(string value)
		{
			return null;
		}

		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return default(TSource);
		}

		public static string ToCamelCase(string s)
		{
			return null;
		}

		public static bool IsHighSurrogate(char c)
		{
			return false;
		}

		public static bool IsLowSurrogate(char c)
		{
			return false;
		}

		public static bool StartsWith(this string source, char value)
		{
			return false;
		}

		public static bool EndsWith(this string source, char value)
		{
			return false;
		}
	}
}
