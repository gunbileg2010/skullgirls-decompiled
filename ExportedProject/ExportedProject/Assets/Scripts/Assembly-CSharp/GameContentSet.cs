using System;
using System.Collections.Generic;
using UnityEngine;

public class GameContentSet : GameContentData
{
	public List<GameContentData> contentDatas;

	public override GameContentDisplayData GetDisplayData()
	{
		return null;
	}

	public override GameType GetGameType()
	{
		return default(GameType);
	}

	public override Act GetAct()
	{
		return null;
	}

	public bool ContainsContent(GameContentData contentData)
	{
		return false;
	}

	public string GetTitle()
	{
		return null;
	}

	public string GetSubtitle()
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	public override bool ShouldBadge()
	{
		return false;
	}

	public override void ClearBadge()
	{
	}

	public override Season GetSeason()
	{
		return default(Season);
	}

	public override string GetLockedText(string overrideText = null)
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

	public bool IsUnlocked(int actIndex)
	{
		return false;
	}

	public override void ForceUnlock()
	{
	}

	public override float GetCompletionRatio()
	{
		return 0f;
	}

	public void LoadAssets()
	{
	}

	public void UnloadAssets()
	{
	}

	public Texture2D GetCoverArtTexture()
	{
		return null;
	}

	public Sprite GetCharacterSprite(ref Texture2D alphaMask)
	{
		return null;
	}

	public float GetCharacterScale()
	{
		return 0f;
	}

	public override DateTime? GetExpirationDateTime()
	{
		return null;
	}

	public override DateTime? GetStartDateTime()
	{
		return null;
	}

	public override string GetEventId()
	{
		return null;
	}

	public string GetEventId(int index)
	{
		return null;
	}

	public int GetOrderPriority()
	{
		return 0;
	}

	public int GetContentIndex(GameContentData dataProvider)
	{
		return 0;
	}

	public int MoveNext(int index)
	{
		return 0;
	}

	public int MovePrev(int index)
	{
		return 0;
	}
}
