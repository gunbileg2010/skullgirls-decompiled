using System;
using System.Collections.Generic;

public class Reward : IComparable<Reward>
{
	private Loot loot;

	private bool isBonus;

	private List<Reward> nestedRewards;

	private Price price;

	private string backendId;

	private List<Stat> stats;

	private bool isShiny;

	public Reward(Loot wrappedLoot)
	{
	}

	public Loot GetLoot()
	{
		return null;
	}

	public void SetNestedRewards(List<Reward> rewards)
	{
	}

	public List<Reward> GetNestedRewards()
	{
		return null;
	}

	public bool HasNestedRewards()
	{
		return false;
	}

	public void MarkAsBonus()
	{
	}

	public bool IsBonus()
	{
		return false;
	}

	public RarityTier GetTier()
	{
		return default(RarityTier);
	}

	public Price GetPrice()
	{
		return null;
	}

	public void SetPrice(Price price)
	{
	}

	public string GetBackendId()
	{
		return null;
	}

	public void SetBackendId(string value)
	{
	}

	public List<Stat> GetStatList()
	{
		return null;
	}

	public void SetStatsList(List<Stat> value)
	{
	}

	public bool IsShiny()
	{
		return false;
	}

	public void SetIsShiny(bool value)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public int CompareTo(Reward other)
	{
		return 0;
	}
}
