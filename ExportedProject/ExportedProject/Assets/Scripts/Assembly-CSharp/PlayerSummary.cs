using UnityEngine;

public class PlayerSummary : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText playerNameText;

	[SerializeField]
	private PlayerNameTextUI playerNameUI;

	[SerializeField]
	private LocalizedUGUIText playerLevelText;

	[SerializeField]
	private RectTransform characterPortraitHolder;

	[SerializeField]
	private CharacterPortrait characterPortrait;

	[SerializeField]
	private RectTransform levelProgressBar;

	[SerializeField]
	private BattleRankBadge riftBattleRankBadge;

	[SerializeField]
	private bool showRiftBattleRank;

	[SerializeField]
	private bool hideRookieRiftBattleRank;

	private Profile profile;

	private bool recycleCharacterPortrait;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Populate(Profile profile)
	{
	}

	public void Populate(XsProfile xsProfile)
	{
	}

	public void Clear()
	{
	}

	public void SetName(string name, bool isDeveloper = false)
	{
	}

	public void SetLevel(int level)
	{
	}

	public void SetLevelProgress(float progress)
	{
	}

	public void SetRepCharacter(Character character)
	{
	}

	public void SetRepCharacter(XsCharacter character)
	{
	}

	public void SetRepCharacter(VariantCharacterData variantData)
	{
	}

	public void SetLabTier(RiftTier labTier)
	{
	}

	public void SetPortraitIsDarkened(bool darken)
	{
	}

	public void UGUI_PlayerSummaryClicked()
	{
	}

	private void TakePortrait()
	{
	}

	private void ClearPortrait()
	{
	}

	private void OnProfileUpdated(Profile profile)
	{
	}
}
