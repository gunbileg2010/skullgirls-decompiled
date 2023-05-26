using System.IO;
using UnityEngine;

public class SGRandomizer : Randomizer
{
	[SerializeField]
	private int usageCount;

	private const int kDefaultSeed = 666666;

	private const int kMaxRandomNumber = 32767;

	private uint seed;

	public override float GetValue()
	{
		return 0f;
	}

	public override int GetIntValue()
	{
		return 0;
	}

	public int GetSeed()
	{
		return 0;
	}

	public void SetSeed(int seed)
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	public int GetUsageCount()
	{
		return 0;
	}

	protected override void ChangeSeed(int? seed)
	{
	}

	private void PrimeRandomGenerator()
	{
	}
}
