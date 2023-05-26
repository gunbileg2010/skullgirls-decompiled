using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugFightSection : MonoBehaviour
{
	[SerializeField]
	private Toggle showStageGridToggle;

	[SerializeField]
	private Toggle markInputsUsedToggle;

	[SerializeField]
	private InputField timeScale;

	[SerializeField]
	private Toggle slotDebugToggle;

	[SerializeField]
	private Toggle playerTeamToggle;

	[SerializeField]
	private Toggle enemyTeamToggle;

	[SerializeField]
	private Dropdown modifierTypeToApplyDropdown;

	[SerializeField]
	private Dropdown modifierStrengthToApplyDropdown;

	[SerializeField]
	private InputField modifierDurationToApplyInput;

	[SerializeField]
	private InputField modifierStacksToApplyInput;

	[SerializeField]
	private Toggle modifierToApplyIsTimelessToggle;

	[SerializeField]
	private Toggle modifierToApplyIsPermanentToggle;

	[SerializeField]
	private Toggle modifierToApplyShouldTriggerEventsToggle;

	[SerializeField]
	private Dropdown modifierTypeToRemoveDropdown;

	[SerializeField]
	private Dropdown modifierStrengthToRemoveDropdown;

	[SerializeField]
	private Toggle removeEveryStrengthToggle;

	[SerializeField]
	private Toggle removePermanentModifiersToggle;

	[SerializeField]
	private Toggle removeEveryModifierToggle;

	[SerializeField]
	private Toggle debugAIToggle;

	[SerializeField]
	private Toggle disableAIToggle;

	[SerializeField]
	private Toggle enableP2InputsToggle;

	[SerializeField]
	private Text AIDifficultyText;

	[SerializeField]
	private Slider AIDifficulty;

	[SerializeField]
	private InputField fightSeed;

	[SerializeField]
	private LocalizedUGUIText characterNameText;

	[SerializeField]
	private LocalizedUGUIText variantNameText;

	[SerializeField]
	private LocalizedUGUIText statsText;

	[SerializeField]
	private Button killButton;

	[SerializeField]
	private Button killAllButton;

	[SerializeField]
	private Button fillAllSuperbarButton;

	private DebugSettings debugSettings;

	private Team currentTeam;

	private Character character;

	private Actor actor;

	private int actorIndex;

	private float cachedFightSpeed;

	private List<Type> modifierTypesToApply;

	private Type modifierTypeToApply;

	private List<ModifierStrength> modifierStrengths;

	private ModifierStrength modifierStrengthToApply;

	private bool modifierToApplyIsTimeless;

	private bool modifierToApplyIsPermanent;

	private bool modifierToApplyShouldTriggerEvents;

	private List<ModifierType> modifierTypesToRemove;

	private ModifierType modifierTypeToRemove;

	private ModifierStrength modifierStrengthToRemove;

	private bool removeEveryStrength;

	private bool removePermanentModifiers;

	private bool removeEveryModifier;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void UGUI_StageGridToggle(bool isOn)
	{
	}

	public void UGUI_MarkInputsUsedToggle(bool isOn)
	{
	}

	public void UGUI_SlotDebugToggle(bool isOn)
	{
	}

	public void UGUI_DebugEnemyAIToggle(bool isOn)
	{
	}

	public void UGUI_DisableEnemyAIToggle(bool isOn)
	{
	}

	public void UGUI_EnableP2InputsToggle(bool isOn)
	{
	}

	public void UGUI_PlayerTeamToggleChanged(bool isOn)
	{
	}

	public void UGUI_EnemyTeamToggleChanged(bool isOn)
	{
	}

	public void UGUI_NextButtonPressed()
	{
	}

	public void UGUI_ModifierTypeToApplyDropdownChanged(int value)
	{
	}

	public void UGUI_ModifierStrengthToApplyDropdownChanged(int value)
	{
	}

	public void UGUI_SetModifierToApplyIsTimelessToggle(bool isOn)
	{
	}

	public void UGUI_SetModifierToApplyIsPermanentToggle(bool isOn)
	{
	}

	public void UGUI_SetModifierToApplyShouldTriggerEventsToggle(bool isOn)
	{
	}

	public void UGUI_ApplyModifierButtonPressed()
	{
	}

	public void UGUI_ModifierTypeToRemoveDropdownChanged(int value)
	{
	}

	public void UGUI_ModifierStrengthToRemoveDropdownChanged(int value)
	{
	}

	public void UGUI_SetRemoveEveryStrengthToggle(bool isOn)
	{
	}

	public void UGUI_SetRemovePermanentModifiersToggle(bool isOn)
	{
	}

	public void UGUI_SetRemoveEveryModifierToggle(bool isOn)
	{
	}

	public void UGUI_RemoveModifiersButtonPressed()
	{
	}

	public void UGUI_AIDifficultyChanged(float difficulty)
	{
	}

	public void UGUI_InputsToggle(bool isOn)
	{
	}

	private void UpdateDifficultyText(int diff)
	{
	}

	private void RefreshCharacterData()
	{
	}

	private void UpdateCharacterInfoText()
	{
	}

	private void SetUpModifierOptions()
	{
	}
}
