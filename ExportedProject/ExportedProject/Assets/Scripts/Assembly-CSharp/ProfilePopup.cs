using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	private GameObject changeHandleButtonGO;

	[SerializeField]
	private GameObject setRepCharacterButtonGO;

	[SerializeField]
	private PopupData portraitChooserPopupData;

	[SerializeField]
	private Fight duelFight;

	[SerializeField]
	private GameObject duelButtonGO;

	[SerializeField]
	private Button removeFriendButton;

	[SerializeField]
	private ProfileTopFighterView itemPrototype;

	[SerializeField]
	private ContextualTutorial profileContextualTutorial;

	private Profile profile;

	private bool displayingCurrentUser;

	private List<CharacterPortrait> characterPortraits;

	private int itemCounter;

	private List<ProfileTopFighterView> items;

	private bool wereCurrenciesPoppedToTop;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_ChangeHandlePressed()
	{
	}

	public void UGUI_SetRepFighterPressed()
	{
	}

	public void UGUI_DuelPressed()
	{
	}

	public void UGUI_RemoveFriendPressed()
	{
	}

	private void Populate()
	{
	}

	private void CleanUp()
	{
	}

	private void OnSectionToggleActivated(Toggle toggle)
	{
	}

	private void PopulateTopFighters()
	{
	}

	private void PopulateHandle()
	{
	}

	private void ClearItems()
	{
	}

	private ProfileTopFighterView GetItem()
	{
		return null;
	}
}
