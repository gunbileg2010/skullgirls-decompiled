using UnityEngine;

public class PlayerOptionsPopup : SGUGUIPopup
{
	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	protected PopupData reportAbusePopupData;

	[SerializeField]
	protected AdvancedButton reportAbuseButton;

	protected XsProfile playerProfile;

	public void UGUI_ReportAbusePressed()
	{
	}

	public void UGUI_ViewProfilePressed()
	{
	}

	protected void SetUpPlayerProfile(XsProfile profile)
	{
	}
}
