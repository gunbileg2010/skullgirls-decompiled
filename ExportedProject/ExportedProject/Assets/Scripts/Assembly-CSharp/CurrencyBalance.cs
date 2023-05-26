using System.Collections.Generic;

public class CurrencyBalance
{
	private int paidAmount;

	private int bonusAmount;

	private int freeAmount;

	public CurrencyBalance()
	{
	}

	public CurrencyBalance(Dictionary<string, object> dict)
	{
	}

	public void ParseFromDict(Dictionary<string, object> dict)
	{
	}

	public void Spend(int amount)
	{
	}

	public void SpendFreeFirst(int amount)
	{
	}

	public void Gain(CurrencyTier tier, int amount)
	{
	}

	public void GainPaid(int amount)
	{
	}

	public void GainBonus(int amount)
	{
	}

	public void GainFree(int amount)
	{
	}

	public int GetTotal()
	{
		return 0;
	}

	public int GetPaid()
	{
		return 0;
	}

	public int GetBonus()
	{
		return 0;
	}

	public int GetFree()
	{
		return 0;
	}

	public CurrencyBalance GetCopy()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
