using System;
using System.Collections.Generic;
using UnityEngine;

namespace HeurekaGames
{
	public static class Extensions
	{
		public static Vector2 YZ(this Vector3 v)
		{
			return default(Vector2);
		}

		public static Vector2[] YZ(this Vector3[] v)
		{
			return null;
		}

		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return 0f;
		}

		public static string ToCamelCase(this string camelCaseString)
		{
			return null;
		}

		public static void SetComponentRecursively<T>(this GameObject gameObject, bool tf) where T : Component
		{
		}

		public static void CastList<T>(this List<T> targetList)
		{
		}

		public static bool Has<T>(this Enum type, T value)
		{
			return false;
		}

		public static bool Is<T>(this Enum type, T value)
		{
			return false;
		}

		public static T Add<T>(this Enum type, T value)
		{
			return default(T);
		}

		public static T Remove<T>(this Enum type, T value)
		{
			return default(T);
		}

		public static Color ModifiedAlpha(this Color color, float alpha)
		{
			return default(Color);
		}
	}
}
