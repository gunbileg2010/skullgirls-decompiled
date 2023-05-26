using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailView : MonoBehaviour
{
	[SerializeField]
	private Text dateText;

	[SerializeField]
	private LocalizedUGUIText subjectText;

	[SerializeField]
	private LocalizedUGUIText bodyText;

	[SerializeField]
	private RawImage bannerImage;

	[SerializeField]
	private GameObject takeActionGO;

	[SerializeField]
	private Button claimButton;

	[SerializeField]
	private GameObject externalIconGO;

	[SerializeField]
	private Button goNowButton;

	[SerializeField]
	private RewardScrollView rewards;

	[SerializeField]
	private Image rightRewardFadeOut;

	[SerializeField]
	private ContextualPopupItem contextualPopupPrefab;

	[SerializeField]
	private Button trashButton;

	private MailScreen mailScreen;

	private MailServerData mailData;

	private List<LocalizedUGUIText> bodyTexts;

	private ContextualPopupItem contextualPopup;

	private void OnDisable()
	{
	}

	public void Init(MailScreen mailScreen)
	{
	}

	public void ShowMail(MailServerData mailData)
	{
	}

	public void Refresh()
	{
	}

	public MailServerData GetCurrentMailData()
	{
		return null;
	}

	public void UGUI_ClaimButtonPressed()
	{
	}

	public void UGUI_GoNowButtonPressed()
	{
	}

	public void UGUI_BackButtonPressed()
	{
	}

	public void UGUI_DeleteButtonPressed()
	{
	}

	private void MarkAsRead()
	{
	}

	private void SetBackButtonCallback(bool clear)
	{
	}
}
