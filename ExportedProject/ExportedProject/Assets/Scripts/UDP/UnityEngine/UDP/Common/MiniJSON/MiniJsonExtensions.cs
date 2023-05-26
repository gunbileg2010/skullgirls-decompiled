using System.Collections.Generic;

namespace UnityEngine.UDP.Common.MiniJSON
{
	public static class MiniJsonExtensions
	{
		public static Dictionary<string, object> GetHash(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static T GetEnum<T>(this Dictionary<string, object> dic, string key)
		{
			return default(T);
		}

		public static string GetString(this Dictionary<string, object> dic, string key, string defaultValue = "")
		{
			return null;
		}

		public static long GetLong(this Dictionary<string, object> dic, string key)
		{
			return 0L;
		}

		public static List<string> GetStringList(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static bool GetBool(this Dictionary<string, object> dic, string key)
		{
			return false;
		}

		public static T Get<T>(this Dictionary<string, object> dic, string key)
		{
			return default(T);
		}

		public static string toJson(this Dictionary<string, object> obj)
		{
			return null;
		}

		public static string toJson(this Dictionary<string, string> obj)
		{
			return null;
		}

		public static string toJson(this string[] array)
		{
			return null;
		}

		public static Dictionary<string, object> HashtableFromJson(this string json)
		{
			return null;
		}
	}
}
