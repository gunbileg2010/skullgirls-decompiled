using UnityEngine;
using UnityEngine.UI;

public class HostedMessagePopup : UGUIPopup
{
	[SerializeField]
	private Text messageText;

	[SerializeField]
	private Text positiveButtonText;

	[SerializeField]
	private LocalizedUGUIText speakerText;

	[SerializeField]
	private TalkingHeadController talkingHeadController;

	[SerializeField]
	private Image speechBubble;

	private HostedMessagePopupData hostedMessagePopupData;

	private TalkingHead talkingHead;

	private TalkingHeadEmote talkingHeadEmote;

	private float desiredScale;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}
}
