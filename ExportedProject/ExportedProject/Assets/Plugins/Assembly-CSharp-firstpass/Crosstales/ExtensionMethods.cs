using System;
using System.Collections.Generic;

namespace Crosstales
{
	public static class ExtensionMethods
	{
		private static readonly Random rd;

		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return false;
		}

		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return false;
		}

		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return false;
		}

		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return false;
		}

		public static void CTShuffle<T>(this T[] array)
		{
		}

		public static string CTDump<T>(this T[] array)
		{
			return null;
		}

		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		public static void CTShuffle<T>(this IList<T> list)
		{
		}

		public static string CTDump<T>(this List<T> list)
		{
			return null;
		}

		public static List<string> CTToString<T>(this List<T> list)
		{
			return null;
		}

		public static void CTAddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}
	}
}
