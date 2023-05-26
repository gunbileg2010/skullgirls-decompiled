using UnityEngine;
using UnityEngine.UI;

public class MailListItem : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText subjectText;

	[SerializeField]
	private LocalizedUGUIText subtitleText;

	[SerializeField]
	private Text dateText;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Color unselectedBgColor;

	[SerializeField]
	private Color selectedBgColor;

	[SerializeField]
	private Image mailIconImage;

	[SerializeField]
	private Sprite unclaimedRewardsSprite;

	[SerializeField]
	private Sprite claimedRewardsSprite;

	[SerializeField]
	private Sprite unreadMailSprite;

	[SerializeField]
	private Sprite readMailSprite;

	[SerializeField]
	private Toggle radioButton;

	private MailScreen myMailScreen;

	private MailServerData myMailData;

	private int kMaxSubjectLength;

	private bool isSelected;

	public void OnDisable()
	{
	}

	public void Populate(MailServerData mailServerData, MailScreen parent)
	{
	}

	public void Refresh(MailScreen parent)
	{
	}

	public MailServerData GetMailData()
	{
		return null;
	}

	public void UGUI_ToggleSelection(bool value)
	{
	}

	public void ToggleSelection(bool value)
	{
	}

	public bool IsSelected()
	{
		return false;
	}
}
