using System;

[Serializable]
public abstract class GameContentData : GuidScriptableObject
{
	protected bool forceUnlocked;

	[NonSerialized]
	protected string eventId;

	protected DateTime startDateTime;

	protected DateTime expirationDateTime;

	public virtual GameContentDisplayData GetDisplayData()
	{
		return null;
	}

	public abstract GameType GetGameType();

	public virtual Season GetSeason()
	{
		return default(Season);
	}

	public virtual Act GetAct()
	{
		return null;
	}

	public virtual bool IsAvailable()
	{
		return false;
	}

	public virtual bool IsUnlocked()
	{
		return false;
	}

	public virtual void ForceUnlock()
	{
	}

	public virtual string GetLockedText(string overrideText = null)
	{
		return null;
	}

	public virtual bool ShouldBadge()
	{
		return false;
	}

	public virtual void ClearBadge()
	{
	}

	public virtual float GetCompletionRatio()
	{
		return 0f;
	}

	public virtual void ResetCompletion()
	{
	}

	public virtual DateTime? GetStartDateTime()
	{
		return null;
	}

	public virtual void SetStartDateTime(DateTime startDateTime)
	{
	}

	public virtual DateTime? GetExpirationDateTime()
	{
		return null;
	}

	public virtual void SetExpirationDateTime(DateTime expirationDateTime)
	{
	}

	public virtual void SetEventId(string eventId)
	{
	}

	public virtual string GetEventId()
	{
		return null;
	}
}
