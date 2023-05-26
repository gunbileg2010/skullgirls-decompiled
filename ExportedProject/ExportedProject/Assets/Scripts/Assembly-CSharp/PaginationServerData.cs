using System.Collections.Generic;

public class PaginationServerData
{
	private string next;

	private string prev;

	public PaginationServerData(Dictionary<string, object> dataDict)
	{
	}

	public bool HasNext()
	{
		return false;
	}

	public string GetNext()
	{
		return null;
	}

	public bool HasPrev()
	{
		return false;
	}

	public string GetPrev()
	{
		return null;
	}
}
