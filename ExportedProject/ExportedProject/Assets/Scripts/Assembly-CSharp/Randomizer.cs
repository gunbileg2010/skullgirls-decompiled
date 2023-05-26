using System;
using System.Collections.Generic;

public abstract class Randomizer
{
	protected static Dictionary<string, Randomizer> randomizerInstances;

	protected static Randomizer defaultRandomizer;

	protected string identifier;

	public static Randomizer SetupInstance(string identifier, int? seed = null)
	{
		return null;
	}

	public static T SetupInstance<T>(string identifier, int? seed = null) where T : Randomizer, new()
	{
		return null;
	}

	public static Randomizer GetInstance(string identifier = null)
	{
		return null;
	}

	public static T GetInstance<T>(string identifier = null) where T : Randomizer, new()
	{
		return null;
	}

	public abstract float GetValue();

	public abstract int GetIntValue();

	public T GetRandomItemFromCollection<T>(IList<T> collection)
	{
		return default(T);
	}

	public T GetRandomWeightedItemFromCollection<T>(IList<T> collection, Func<T, float> itemWeight)
	{
		return default(T);
	}

	public void ShuffleCollection<T>(IList<T> collection)
	{
	}

	public float Range(float min, float max, bool inclusiveMin = true, bool inclusiveMax = true)
	{
		return 0f;
	}

	public bool EvaluateProbability(float probability)
	{
		return false;
	}

	public int Range(int min, int max)
	{
		return 0;
	}

	public string GetIdentifier()
	{
		return null;
	}

	public void SetIdentifier(string identifier)
	{
	}

	private static T GetDefaultRandomizer<T>() where T : Randomizer, new()
	{
		return null;
	}

	protected abstract void ChangeSeed(int? seed = null);

	protected float FloatRange(float min, float max)
	{
		return 0f;
	}
}
