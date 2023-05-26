using System;
using UnityEngine;

[Serializable]
public class DialogueItem
{
	public enum SpeakerPosition
	{
		Left = 0,
		Right = 1,
		StageDirection = 2,
		Fullscreen = 3
	}

	public SpeakerPosition position;

	public SpeakerPosition whoIsSpeaking;

	public bool clearOpposite;

	public bool converted;

	public TalkingHeadTransitionType transition;

	public TalkingHeadTransitionType transitionRight;

	public TalkingHeadTransitionType transitionLeft;

	public string audioClip;

	public TalkingHead talkingHead;

	public string talkingHeadEmote;

	public TalkingHead talkingHeadRight;

	public TalkingHead talkingHeadLeft;

	public int talkingHeadRightEmoteIndex;

	public int talkingHeadLeftEmoteIndex;

	[SerializeField]
	private DynamicResource backgroundTexture;

	[TextArea]
	public string dialogue;

	[NonSerialized]
	private AudioClip voClip;

	[NonSerialized]
	private Sprite leftSprite;

	[NonSerialized]
	private Sprite rightSprite;

	[NonSerialized]
	private Texture2D cachedBG;

	public string GetSpeakerName()
	{
		return null;
	}

	public Color GetDialogueBubbleColor()
	{
		return default(Color);
	}

	public Sprite GetSprite(ref Texture2D alphaMask, SpeakerPosition position)
	{
		return null;
	}

	public float GetScale(SpeakerPosition position)
	{
		return 0f;
	}

	public float GetAlpha(SpeakerPosition position)
	{
		return 0f;
	}

	public AudioClip GetVOClip()
	{
		return null;
	}

	public string GetBackgroundPath()
	{
		return null;
	}

	public Texture2D GetBackground()
	{
		return null;
	}

	public void ReleaseResources()
	{
	}
}
