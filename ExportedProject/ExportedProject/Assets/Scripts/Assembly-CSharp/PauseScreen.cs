using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText playerNameText;

	[SerializeField]
	private LocalizedUGUIText playerVariantNameText;

	[SerializeField]
	private LocalizedUGUIText enemyNameText;

	[SerializeField]
	private LocalizedUGUIText enemyVariantNameText;

	[SerializeField]
	private RectTransform playerModScrollContentArea;

	[SerializeField]
	private RectTransform enemyModScrollContentArea;

	[SerializeField]
	private PauseScreenModifier modifierPrefab;

	[SerializeField]
	private PopupData confirmPopupData;

	[SerializeField]
	private GameObject quitButtonGO;

	private static readonly uint PAUSE_SPARK_HASH;

	private static readonly uint UNPAUSE_SPARK_HASH;

	private List<PauseScreenModifier> modifierGOs;

	public void Show(bool playShowSfx)
	{
	}

	public void Hide(bool playSfx)
	{
	}

	public bool IsPaused()
	{
		return false;
	}

	public void UGUI_QuitButtonPressed()
	{
	}

	public void UGUI_ResumeButtonPressed()
	{
	}

	private void DisplayModifiers(TeamType teamType)
	{
	}

	private void DisplayElementalAffiliationModifiers(Actor playerActor, TeamType teamType)
	{
	}

	private void DisplaySignatureAbility(Character character, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DisplaySuperAbility(Character character, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DisplayCharacterAbilityStatus(Actor actor, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DisplayPrestigeAbility(Character character, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DisplayCurrentModifiers(Actor actor, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DisplayFightModifiers(Fight fight, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DisplayCollectibleNodeModifiers(Fight fight)
	{
	}

	private void DisplayCharacterName(Character character, TeamType teamType)
	{
	}

	private PauseScreenModifier CreateModifier(TeamType teamType)
	{
		return null;
	}

	private void PlayPauseUnpauseSfx(bool pause = true)
	{
	}
}
