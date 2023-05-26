using System;
using System.Collections.Generic;

public static class RandomizerExtensions
{
	public static T GetRandomItem<T>(this IList<T> collection, string identifier = null)
	{
		return default(T);
	}

	public static T GetRandomWeightedItem<T>(this IList<T> collection, Func<T, float> itemWeight, string identifier = null)
	{
		return default(T);
	}
}
