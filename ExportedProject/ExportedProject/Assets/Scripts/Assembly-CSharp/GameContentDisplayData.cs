using System;
using UnityEngine;

[Serializable]
public class GameContentDisplayData
{
	[SerializeField]
	private string title;

	[SerializeField]
	private string subtitle;

	[SerializeField]
	private string description;

	[SerializeField]
	private DynamicResource coverArtResource;

	[SerializeField]
	private TalkingHead talkingHead;

	[SerializeField]
	private string talkingHeadEmote;

	[SerializeField]
	private int orderPriority;

	private TalkingHeadEmote emoteInUse;

	private Sprite characterColorSprite;

	private Texture2D characterAlphaTexture;

	private Texture2D coverArtTexture;

	public string GetTitle(bool localized = true)
	{
		return null;
	}

	public string GetSubtitle(bool localized = true)
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	public void LoadAssets()
	{
	}

	public void UnloadAssets()
	{
	}

	public Sprite GetCharacterSprite(ref Texture2D alphaMask)
	{
		return null;
	}

	public float GetCharacterScale()
	{
		return 0f;
	}

	public Texture2D GetCoverArtTexture()
	{
		return null;
	}

	public int GetOrderPriority()
	{
		return 0;
	}
}
