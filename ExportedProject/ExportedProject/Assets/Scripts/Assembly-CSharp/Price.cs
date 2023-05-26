using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Price
{
	[SerializeField]
	private List<Currency> currencies;

	public static Price GetScaledPrice(Price originalPrice, int multiplier)
	{
		return null;
	}

	public Price(params Currency[] currencyParams)
	{
	}

	public Price(Dictionary<string, object> priceDict)
	{
	}

	public Currency GetCurrency(CurrencyType currencyType)
	{
		return null;
	}

	public int GetAmountIn(CurrencyType currencyType)
	{
		return 0;
	}

	public CurrencyType GetCurrencyType()
	{
		return default(CurrencyType);
	}

	public int GetAmount()
	{
		return 0;
	}

	public List<Currency> GetCurrencies()
	{
		return null;
	}

	public int GetCurrenciesCount()
	{
		return 0;
	}

	public Currency GetCurrencyAt(int index)
	{
		return null;
	}

	public void AddCurrency(Currency currency)
	{
	}

	public bool IsFree()
	{
		return false;
	}

	public void ParseFromServerData(Dictionary<string, object> priceDict)
	{
	}

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}

	public static List<object> ToDictionaries(List<Price> prices)
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
