using System;
using System.Collections.Generic;

public abstract class OfferServerData
{
	public string guid;

	public int displayOrder;

	public float specificOfferPopupCooldownHours;

	public string overrideOfferWithGuid;

	public int standardLootAmount;

	private OfferData clientData;

	private bool searchedForClientData;

	public OfferServerData()
	{
	}

	public OfferServerData(Dictionary<string, object> dataDict)
	{
	}

	public abstract string GetOfferId();

	public virtual bool IsAvailable()
	{
		return false;
	}

	public bool HasExpired()
	{
		return false;
	}

	public virtual DateTime GetExpirationDate()
	{
		return default(DateTime);
	}

	public virtual int GetActivePurchaseIndex()
	{
		return 0;
	}

	public PurchaseAction GetActivePurchaseAction()
	{
		return null;
	}

	public OfferLoots GetActiveOfferLoots()
	{
		return null;
	}

	public bool CanScheduleNotification()
	{
		return false;
	}

	public bool CanShowOfferPopup()
	{
		return false;
	}

	public long GetLastPopupShownDay()
	{
		return 0L;
	}

	public void SavePopupShown()
	{
	}

	public void ClearPopupShown()
	{
	}

	public void ShowOfferPopup(bool force, bool withDismissReminder, OfferData.OfferPopupShownDelegate callback, string additionalContext = null, bool allowMultifold = true, bool shouldQueue = true)
	{
	}

	public virtual bool IsOnSale()
	{
		return false;
	}

	public virtual bool CanBePurchased()
	{
		return false;
	}

	public virtual int GetRemainingPurchases()
	{
		return 0;
	}

	public virtual void DecrementRemainingPurchases()
	{
	}

	public bool HasProductId(string productId)
	{
		return false;
	}

	public OfferData GetClientData()
	{
		return null;
	}

	public string GetMetricsGuid()
	{
		return null;
	}

	public bool IsFree()
	{
		return false;
	}

	private string GetSaveDataKey()
	{
		return null;
	}

	private int GetDaysLeftToExpire()
	{
		return 0;
	}
}
