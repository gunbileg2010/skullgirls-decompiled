using System;
using System.Collections.Generic;

[Serializable]
public class DirectPurchaseTabInfo
{
	public string mappingName;

	public string locKey;

	public int tabIconIndex;

	public DirectPurchaseTabInfo()
	{
	}

	public DirectPurchaseTabInfo(Dictionary<string, object> serverData)
	{
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public void Parse(Dictionary<string, object> serverData)
	{
	}
}
