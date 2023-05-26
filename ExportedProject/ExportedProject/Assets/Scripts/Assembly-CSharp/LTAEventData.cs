using System;
using System.Collections.Generic;
using UnityEngine;

public class LTAEventData : EventData
{
	[SerializeField]
	private Act act;

	[SerializeField]
	private List<Loot> firstTimeCompletionLoots;

	[SerializeField]
	private List<Loot> firstTimeFullCompletionLoots;

	[SerializeField]
	private bool isSkippable;

	[SerializeField]
	private int maxPlaysAllowed;

	public override EventDataType GetEventType()
	{
		return default(EventDataType);
	}

	public override void ForceUnlock()
	{
	}

	public override GameContentDisplayData GetDisplayData()
	{
		return null;
	}

	public override float GetCompletionRatio()
	{
		return 0f;
	}

	public override void ResetCompletion()
	{
	}

	public override DateTime? GetExpirationDateTime()
	{
		return null;
	}

	public override GameType GetGameType()
	{
		return default(GameType);
	}

	public override string GetLockedText(string overrideText = null)
	{
		return null;
	}

	public override DateTime? GetStartDateTime()
	{
		return null;
	}

	public override bool IsAvailable()
	{
		return false;
	}

	public override bool IsUnlocked()
	{
		return false;
	}

	public override Act GetAct()
	{
		return null;
	}

	public bool GetIsSkippable()
	{
		return false;
	}

	public int GetMaxPlaysAllowed()
	{
		return 0;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
