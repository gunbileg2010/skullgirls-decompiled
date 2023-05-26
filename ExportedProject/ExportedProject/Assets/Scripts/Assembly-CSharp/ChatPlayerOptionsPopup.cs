using UnityEngine;
using UnityEngine.UI;

public class ChatPlayerOptionsPopup : PlayerOptionsPopup
{
	[SerializeField]
	private Button addFriendButton;

	[SerializeField]
	private LocalizedUGUIText muteButtonText;

	private ChatMessage chatMessage;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	public void UGUI_MutePressed()
	{
	}

	public void UGUI_AddFriendPressed()
	{
	}

	public new void UGUI_ReportAbusePressed()
	{
	}

	private void RefreshButtonStates()
	{
	}
}
