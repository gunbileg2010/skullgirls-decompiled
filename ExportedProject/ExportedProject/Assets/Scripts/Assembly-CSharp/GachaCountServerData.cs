using System.Collections.Generic;

public class GachaCountServerData
{
	public string guid;

	public int count;

	public Dictionary<int, int> voucherCountMap;

	public void ParseData(Dictionary<string, object> dataDict, bool addToExistingTotals = false)
	{
	}

	public bool HasAtLeastOne()
	{
		return false;
	}

	public int GetTotalOpenableCount()
	{
		return 0;
	}

	public void AddVoucher(int denomination, int amount)
	{
	}

	public bool GetFirstAvailableVoucher(out int denominationIndex, out int count)
	{
		denominationIndex = default(int);
		count = default(int);
		return false;
	}
}
