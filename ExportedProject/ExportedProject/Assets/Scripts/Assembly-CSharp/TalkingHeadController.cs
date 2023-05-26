using System.Collections;
using UnityEngine;

public class TalkingHeadController : MonoBehaviour
{
	[SerializeField]
	private TalkingHeadImage talkingHeadImage;

	[SerializeField]
	private float transitionTime;

	[SerializeField]
	private float fadeTime;

	[SerializeField]
	private float flipTime;

	[SerializeField]
	private TalkingHead presetTalkingHead;

	[SerializeField]
	private string presetEmote;

	[SerializeField]
	private TalkingHeadTransitionType presetTransitionType;

	[SerializeField]
	private bool showPresetOnEnable;

	private TalkingHead currentTalkingHead;

	private TalkingHeadEmote currentEmote;

	private TalkingHeadEmote lastEmote;

	private bool isTransitioning;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Set(TalkingHead talkingHead, string talkingHeadEmote = null, TalkingHeadTransitionType transitionType = TalkingHeadTransitionType.Translate, float scale = 1f, float alpha = 1f)
	{
	}

	public void Set(TalkingHead talkingHead, int emoteIndex, TalkingHeadTransitionType transitionType = TalkingHeadTransitionType.Translate, float scale = 1f, float alpha = 1f)
	{
	}

	public void SetWithSpriteAndAlpha(Sprite sprite, Texture2D alphaMask, TalkingHeadTransitionType transitionType = TalkingHeadTransitionType.None, float scale = 1f, float alpha = 1f)
	{
	}

	public void Hide(bool immediate = false)
	{
	}

	public void ClearImage()
	{
	}

	public void ShowPreset()
	{
	}

	private void InternalSet(Sprite sprite, Texture2D alphaMask, TalkingHeadTransitionType transitionType, float scale, float alpha)
	{
	}

	private IEnumerator DoTranslateSwap(Sprite characterSprite, Texture2D characterAlphaMask, float desiredScale, float desiredAlpha)
	{
		return null;
	}

	private IEnumerator DoFadeSwap(Sprite characterSprite, Texture2D characterAlphaMask, float desiredScale, float desiredAlpha)
	{
		return null;
	}

	private IEnumerator DoFlipSwap(Sprite characterSprite, Texture2D characterAlphaMask, float desiredScale, float desiredAlpha)
	{
		return null;
	}

	private void ReturnLastEmote()
	{
	}

	private void ChangeImage(Sprite characterSprite, Texture2D characterAlphaMask, float desiredScale, float desiredAlpha)
	{
	}
}
