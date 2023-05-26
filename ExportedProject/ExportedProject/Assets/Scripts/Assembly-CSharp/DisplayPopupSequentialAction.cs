using UnityEngine;

public class DisplayPopupSequentialAction : SequentialAction
{
	[SerializeField]
	private PopupData popupData;

	[SerializeField]
	private string popupText;

	[SerializeField]
	private TalkingHead talkingHead;

	[SerializeField]
	private string talkingHeadEmote;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	protected override void FinishAction()
	{
	}
}
