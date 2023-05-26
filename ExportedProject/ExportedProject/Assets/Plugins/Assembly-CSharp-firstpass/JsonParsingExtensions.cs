using System.Collections.Generic;

public static class JsonParsingExtensions
{
	public static UValue TryGet<UValue>(this Dictionary<string, object> dictionary, string key, UValue defaultValue = default(UValue))
	{
		return default(UValue);
	}

	public static T TryGetEnum<T>(this Dictionary<string, object> dictionary, string key, T defaultValue) where T : struct
	{
		return default(T);
	}

	public static List<T> CastToList<T>(this List<object> list)
	{
		return null;
	}
}
