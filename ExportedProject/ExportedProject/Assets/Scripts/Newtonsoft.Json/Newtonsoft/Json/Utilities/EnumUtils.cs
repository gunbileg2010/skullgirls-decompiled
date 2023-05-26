using System;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class EnumUtils
	{
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType;

		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
		{
			return null;
		}

		public static IList<object> GetValues(Type enumType)
		{
			return null;
		}

		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			return null;
		}

		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			return null;
		}

		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText)
		{
			return null;
		}
	}
}
