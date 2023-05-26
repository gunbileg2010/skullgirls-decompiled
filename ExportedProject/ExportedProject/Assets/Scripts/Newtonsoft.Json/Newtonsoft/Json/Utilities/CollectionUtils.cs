using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal static class CollectionUtils
	{
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return false;
		}

		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		public static void AddRange<T>(this IList<T> initial, IEnumerable collection)
		{
		}

		public static bool IsDictionaryType(Type type)
		{
			return false;
		}

		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return 0;
		}

		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			return false;
		}

		public static int IndexOfReference<T>(this List<T> list, T item)
		{
			return 0;
		}

		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}
	}
}
