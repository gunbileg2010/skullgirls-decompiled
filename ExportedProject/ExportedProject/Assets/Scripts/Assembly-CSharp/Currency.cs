using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Currency
{
	[SerializeField]
	private CurrencyType currencyType;

	[SerializeField]
	private int amount;

	protected object context;

	public static Currency GetScaledCurrency(Currency original, int multiplier)
	{
		return null;
	}

	public static Currency GetContextualCurrency(Currency original, object context)
	{
		return null;
	}

	public Currency(CurrencyType currencyType, int amount, object context = null)
	{
	}

	public Currency(Dictionary<string, object> currencyDict)
	{
	}

	public CurrencyType GetCurrencyType()
	{
		return default(CurrencyType);
	}

	public int GetAmount()
	{
		return 0;
	}

	public void SetAmount(int amount)
	{
	}

	public object GetContext()
	{
		return null;
	}

	public void SetContext(object context)
	{
	}

	public void ParseFromServerData(Dictionary<string, object> currencyDict)
	{
	}

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}

	public static Dictionary<string, object> CreateCurrencyAmountDict(CurrencyType currencyType, int amount)
	{
		return null;
	}

	public static Dictionary<CurrencyType, int> TotalCurrency(List<Currency> currencies)
	{
		return null;
	}

	public static List<Currency> TotalCurrencyAsList(List<Currency> currencies)
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
