using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DebugProgressionSection : MonoBehaviour
{
	[SerializeField]
	private GameObject skipFtueButtonGO;

	[SerializeField]
	private GameObject skipMoveEquipTutorialButton;

	[SerializeField]
	private GameObject skipSkillTreeTutorialButton;

	[SerializeField]
	private GameObject skipRiftBattleTutorialButton;

	[SerializeField]
	private InputField currencyInputField;

	[SerializeField]
	private Toggle[] toggles;

	[SerializeField]
	private InputField playerLevelInputField;

	private CurrencyType currencyTypeToAffect;

	private bool socialGiftToOpenContext;

	private void OnEnable()
	{
	}

	public void UGUI_GiveAllCollectibles()
	{
	}

	public void UGUI_MaxOutCollection()
	{
	}

	public void UGUI_ResetCollection()
	{
	}

	public void UGUI_SetCollectionForPvp()
	{
	}

	public void UGUI_SetAllSuperAbilitiesToFeature(int featureSet)
	{
	}

	public void UGUI_ResetContextualTutorials()
	{
	}

	public void UGUI_ClearData()
	{
	}

	public void UGUI_SetCurrency()
	{
	}

	public void UGUI_AddCurrency()
	{
	}

	public void UGUI_ResetFreeTicketProgress()
	{
	}

	public void UGUI_ToggleCurrency_SoftCurrency()
	{
	}

	public void UGUI_ToggleCurrency_HardCurrency()
	{
	}

	public void UGUI_ToggleCurrency_Keys()
	{
	}

	public void UGUI_ToggleCurrency_Skillpoints()
	{
	}

	public void UGUI_ToggleCurrency_Essence()
	{
	}

	public void UGUI_ToggleCurrency_EssenceShard()
	{
	}

	public void UGUI_ToggleCurrency_GachaShard()
	{
	}

	public void UGUI_ToggleCurrency_BattleCurrency()
	{
	}

	public void UGUI_ToggleCurrency_BattleTicket()
	{
	}

	public void UGUI_ToggleCurrency_DailyEventTicket()
	{
	}

	public void UGUI_ToggleCurrency_EnergyRefill()
	{
	}

	public void UGUI_ToggleCurrency_StandardGift(bool toOpen)
	{
	}

	public void UGUI_ToggleCurrency_GoldGift(bool toOpen)
	{
	}

	public void UGUI_ToggleCurrency_CharacterGachaShard()
	{
	}

	public void UGUI_ToggleCurrency_RerollRune()
	{
	}

	public void UGUI_ToggleCurrency_UniversalRerollRune()
	{
	}

	public void UGUI_SetSALevel(int value)
	{
	}

	public void UGUI_SetPlayerLevel()
	{
	}

	public void UGUI_AddPlayerXp()
	{
	}

	public void UGUI_SkipFTUEPressed()
	{
	}

	public void UGUI_SkipMoveEquipTutorialPressed()
	{
	}

	public void UGUI_SkipSkillTreeTutorialPressed()
	{
	}

	public void UGUI_SkipRiftBattleTutorialPressed()
	{
	}

	public void UGUI_ResetRiftBattleTutorialProgressPressed()
	{
	}

	public void UGUI_TestStashMetricEvent()
	{
	}

	public void UGUI_MaxOutCollectionSize()
	{
	}

	private IEnumerator MaxOutAllCharactersAndGears()
	{
		return null;
	}

	private void RefreshProfile(FullUserDataType fullUserDataType = FullUserDataType.All)
	{
	}

	private void SkipSecondaryTutorial(TutorialType tutorialType)
	{
	}
}
