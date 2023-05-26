using System.Collections.Generic;

public class ConsumableServerData
{
	private string guid;

	private int count;

	private long expirationTimestamp;

	private bool isNew;

	public ConsumableServerData()
	{
	}

	public ConsumableServerData(Dictionary<string, object> dict)
	{
	}

	public string GetGuid()
	{
		return null;
	}

	public void SetGuid(string guid)
	{
	}

	public int GetCount()
	{
		return 0;
	}

	public void SetCount(int amount)
	{
	}

	public void IncreaseCount(int amount)
	{
	}

	public void DecreaseCount(int amount)
	{
	}

	public long GetExpirationTimestamp()
	{
		return 0L;
	}

	public void SetExpirationTimestamp(long expirationTimestamp)
	{
	}

	public bool GetIsNew()
	{
		return false;
	}

	public void SetIsNew(bool isNew)
	{
	}

	public void UpdateFromConsumableServerData(ConsumableServerData copyFrom)
	{
	}
}
