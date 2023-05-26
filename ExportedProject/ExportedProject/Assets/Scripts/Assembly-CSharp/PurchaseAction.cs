using System;
using System.Collections.Generic;

[Serializable]
public class PurchaseAction
{
	public string name;

	public PurchaseSticker sticker;

	public virtual string GetProductId()
	{
		return null;
	}

	public virtual bool HasProductId(string productId)
	{
		return false;
	}

	public virtual bool IsReadyToBePurchased()
	{
		return false;
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public virtual void UpdateFromGameDefinition(Dictionary<string, object> dataDict)
	{
	}
}
