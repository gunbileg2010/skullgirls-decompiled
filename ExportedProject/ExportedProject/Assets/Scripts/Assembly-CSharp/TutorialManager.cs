using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
	[Serializable]
	private class FightConfiguration
	{
		public Fight fight;

		public List<CharacterGenerator> playerCharacterGenerators;
	}

	public const int kFTUEClearedProgress = 8;

	public const int kRiftBattleClearedProgress = 5;

	[SerializeField]
	private Act ftueV2TutorialAct;

	[SerializeField]
	private ScriptedSequence[] ftueV2StepTutorials;

	[SerializeField]
	private FightConfiguration[] ftueV2FightConfigurations;

	[SerializeField]
	private List<CharacterGenerator> finalTeamCompositionV2;

	[SerializeField]
	private Act moveEquipAct;

	[SerializeField]
	private ScriptedSequence[] moveEquippingStepTutorials;

	[SerializeField]
	private PopupData characterDetailsLockedPopupData;

	[SerializeField]
	private ScriptedSequence[] skillTreeStepTutorials;

	[SerializeField]
	private ScriptedSequence[] riftBattlesStepTutorials;

	[SerializeField]
	private Act xpBoostAct;

	[SerializeField]
	private ScriptedSequence[] xpBoostStepTutorials;

	[SerializeField]
	private ScriptedSequence[] activeXPBoostTutorials;

	[SerializeField]
	private int debugFastForwardStopStep;

	[SerializeField]
	private PopupData debugStartFTUEPopupData;

	[SerializeField]
	private PopupData debugContinueFTUEPopupData;

	[SerializeField]
	private PopupData debugSkipSecondaryTutorialsPopupData;

	private Dictionary<TutorialType, int> tutorialProgressMap;

	private int completedTutorials;

	private bool wantSkipFTUEAtFrontend;

	private SetTeamCompositionSequentialAction setTeam;

	private ActServerData ftueActServerData;

	private ActServerData moveEquipActServerData;

	private bool isXPBoostTutorialRunning;

	private const string kRiftBattleTutorialSaveKey = "rb2Tutorial";

	private const string kFTUEStep1GachaGuid = "0";

	private const string kFTUEFinalGachaGuid = "13";

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnActiveSceneChanged(Scene from, Scene to)
	{
	}

	public void ContinueTutorial(TutorialType tutorialType)
	{
	}

	public void ContinueTutorialAtStep(TutorialType tutorialType, int step)
	{
	}

	public void SaveTutorialProgressToServer(TutorialType tutorialType, int step, bool showLoading, Action<SetTutorialProgressRequest> callback, string context = null)
	{
	}

	public void UpdateTutorialProgressFromUserServerData(UserServerData userData)
	{
	}

	public void SetTutorialProgress(TutorialType tutorialType, int progress)
	{
	}

	public void MarkTutorialComplete(TutorialType tutorialType)
	{
	}

	public int GetTutorialProgress(TutorialType tutorialType)
	{
		return 0;
	}

	public bool HasClearedTutorial(TutorialType tutorialType)
	{
		return false;
	}

	public int GetTutorialClearedProgress(TutorialType tutorialType)
	{
		return 0;
	}

	public void ShowCharacterDetailsLockedPopup()
	{
	}

	public ScriptedSequence GetRiftBattlesStepTutorial(int sequenceNumber)
	{
		return null;
	}

	public void ResetRiftBattleProgress()
	{
	}

	public bool HasSeenPrestigeAbilityTutorial()
	{
		return false;
	}

	public void ShowPrestigeAbilityTutorial(Action callback = null)
	{
	}

	public void DEBUG_WantFastForwardAtFrontend()
	{
	}

	public void DEBUG_FastForwardTutorialFromStep(TutorialType tutorialType, int currentStep)
	{
	}

	public void DEBUG_FastForwardTutorial(TutorialType tutorialType, Action<bool, int> callback)
	{
	}

	public void DEBUG_MaybeShowSkipSecondaryTutorialsPopup(bool forceSkipFtue = false)
	{
	}

	private void SetupTeam(Fight fight, Action completeCallback = null)
	{
	}

	private void SetTeamComposition(List<CharacterGenerator> playerCharacterGenerators, Action completeCallback = null)
	{
	}

	private void DEBUG_FastForwardFight(int matchIndex, Action<bool> callback)
	{
	}

	private void DetectAndFixTutorialIssues(TutorialType tutorialType, int step, Action<int> callback)
	{
	}

	private void DEBUG_FastForwardSecondaryTutorials(Action<bool> callback)
	{
	}

	private void DEBUG_ShowSkipSecondaryTutorialsPopup(bool forceSkipFtue = false)
	{
	}

	private void ContinueFTUE()
	{
	}

	private void DEBUG_FastForwardFTUE(int currentStep, Action<bool, int> callback)
	{
	}

	private void DetectAndFixFTUEV2Issues(int step, Action<int> callback)
	{
	}

	public void ContinueFTUEV2AtStep(int step)
	{
	}

	private void DEBUG_PerformFTUEV2Step(int step, int stopAtStep = 8, Action<bool, int> callback = null)
	{
	}

	private int GetABTestStateForTutorialType(TutorialType tutorialType)
	{
		return 0;
	}

	private Act GetFTUEAct()
	{
		return null;
	}

	private FightConfiguration[] GetFTUEFightConfigurations()
	{
		return null;
	}

	private List<CharacterGenerator> GetFinalTeamComposition()
	{
		return null;
	}

	private void ContinueMoveEquip()
	{
	}

	private void ContinueMoveEquipAtStep(int step)
	{
	}

	private void DetectAndFixMoveEquipIssues(int step, Action<int> callback)
	{
	}

	private void DEBUG_FastForwardMoveEquipTutorial(Action<bool, int> callback)
	{
	}

	private void ContinueSkillTree()
	{
	}

	private void ContinueSkillTreeAtStep(int step)
	{
	}

	private void DetectAndFixSkillTreeIssues(int step, Action<int> callback)
	{
	}

	private void DEBUG_FastForwardSkillTreeTutorial(Action<bool, int> callback)
	{
	}

	private void DEBUG_FastForwardRiftBattleTutorial(Action<bool, int> callback)
	{
	}

	public bool IsXPBoostTutorialRunning()
	{
		return false;
	}

	public SGMatch GetXpBoostTutorialMatch()
	{
		return null;
	}

	private void ContinueXpBoost()
	{
	}

	private void ContinueXPBoostAtStep(int step)
	{
	}

	private void DetectAndFixXpBoostIssues(int step, Action<int> callback)
	{
	}
}
