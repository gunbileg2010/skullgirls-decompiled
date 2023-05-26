using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FightResultsPopupXPPanel : FightResultsPopupPanel
{
	[SerializeField]
	private FightResultsPopup parent;

	[SerializeField]
	private CharacterCardXpContainer experienceLevelUpPrefab;

	[SerializeField]
	private Transform winCardContainer;

	[SerializeField]
	private Sprite longshotIcon;

	[SerializeField]
	private GameObject postLossUIParentGO;

	[SerializeField]
	private Transform loseCardContainer;

	[SerializeField]
	private Image tipIcon;

	[SerializeField]
	private Image tipIconFrame;

	[SerializeField]
	private LocalizedUGUIText tipDescriptionLocText;

	[SerializeField]
	private FighterScoreComparison fighterScoresDial;

	[SerializeField]
	private GameObject consumableTimerParent;

	[SerializeField]
	private TimerUI consumableTimers;

	[SerializeField]
	private DynamicResourceHelper consumableImageDynamicResourceLoader;

	[SerializeField]
	private ImageColorEzSelfContainedAnimator glowController;

	[SerializeField]
	private float delayBetweenCards;

	[SerializeField]
	private float cardAnimateInDuration;

	private CharacterCardXpContainer[] cardXPContainers;

	private CharacterCard[] characterCards;

	private Image[] childImages;

	private float xpMultiplier;

	private bool readyToContinue;

	public override bool NeedsToDisplay(bool playerWon, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false)
	{
		return false;
	}

	public override IEnumerator ShowResultsSequence(bool playerWon, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false)
	{
		return null;
	}

	public override void UGUI_Continue()
	{
	}

	public override void UGUI_Quit()
	{
	}

	public override void UGUI_Retry()
	{
	}

	public override void Cleanup()
	{
	}

	private void Finish()
	{
	}

	private void UpdateAndShowConsumableSticker()
	{
	}

	private void FadeInImages(float alpha)
	{
	}

	private void StopXPAnimations()
	{
	}

	private void CleanupCards()
	{
	}
}
