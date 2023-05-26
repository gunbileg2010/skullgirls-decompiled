using UnityEngine;

public class TalkingHead : ScriptableObject
{
	[SerializeField]
	private string displayName;

	[SerializeField]
	private Color32 dialogueBubbleTint;

	[SerializeField]
	private float relativeScale;

	public TalkingHeadEmote[] emotes;

	public string GetDisplayName()
	{
		return null;
	}

	public Color32 GetDialogueBubbleTint()
	{
		return default(Color32);
	}

	public float GetRelativeScale()
	{
		return 0f;
	}

	public TalkingHeadEmote GetEmote(int index)
	{
		return null;
	}

	public TalkingHeadEmote GetEmote(string emoteName)
	{
		return null;
	}

	public Sprite TakeEmoteSprite(int emoteIndex, ref Texture2D alphaMaskTexture)
	{
		return null;
	}

	public Sprite TakeEmoteSprite(string emoteName, ref Texture2D alphaMaskTexture)
	{
		return null;
	}

	public void ReturnEmoteSprite(string emoteName)
	{
	}

	public void ReturnEmoteSprite(int emoteIndex)
	{
	}

	public GUIContent[] GetEmoteListForEditor()
	{
		return null;
	}

	public int GetEmoteIndex(string emoteName)
	{
		return 0;
	}
}
