using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryDialogPopup : UGUIPopup
{
	[SerializeField]
	private StoryDialogItemController dialogItemController;

	[SerializeField]
	private RectTransform dialogContainer;

	[SerializeField]
	private RectTransform fullscreenDialogContainer;

	[SerializeField]
	private TalkingHeadController leftSpeaker;

	[SerializeField]
	private TalkingHeadController rightSpeaker;

	[SerializeField]
	private GameObject skipButtonGO;

	[SerializeField]
	private RawImage background;

	[SerializeField]
	private CanvasGroup backgroundCanvas;

	private StoryDialogPopupData storyDialoguePopupData;

	private List<DialogueItem> dialog;

	private StoryDialogItemController dialogueItem;

	private int idx;

	private bool showTopbarOnHide;

	private bool wasBackButtonPressed;

	private EZAnimation backgroundAnim;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Back()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public bool WasBackButtonPressed()
	{
		return false;
	}

	public void UGUI_ShowNextDialog()
	{
	}

	private bool DisplayDialogItemAt(int index)
	{
		return false;
	}

	private void UpdateAllDialogBubbles()
	{
	}

	private void PlayVOClip(AudioClip audioClip)
	{
	}

	private void FadeInBackground()
	{
	}

	private void FadeOutBackground()
	{
	}

	private void UpdateTalkingHead(TalkingHeadController controller, DialogueItem dialogueItem, DialogueItem.SpeakerPosition position)
	{
	}
}
