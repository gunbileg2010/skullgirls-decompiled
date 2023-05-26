using System.Collections.Generic;
using UnityEngine;

public class FightModifiersPopup : SGUGUIPopup
{
	[SerializeField]
	private PauseScreenModifier modifierPrefab;

	[SerializeField]
	private PauseScreenConstraint constraintPrefab;

	[SerializeField]
	private RectTransform playerModScrollContentArea;

	[SerializeField]
	private RectTransform enemyModScrollContentArea;

	[SerializeField]
	private LocalizedUGUIText playerLabel;

	[SerializeField]
	private LocalizedUGUIText enemyLabel;

	[SerializeField]
	private string defaultPlayerLocKey;

	[SerializeField]
	private string defaultEnemyLocKey;

	[SerializeField]
	private string defenseSetupPlayerLocKey;

	[SerializeField]
	private string defenseSetupEnemyLocKey;

	private GameObjectPool<PauseScreenModifier> modifierListItemPool;

	private List<PauseScreenModifier> modifierListItems;

	private GameObjectPool<PauseScreenConstraint> constraintItemListPool;

	private List<PauseScreenConstraint> constraintItemList;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void PopulateFightModifiers(Fight fight, TeamType teamType = TeamType.PLAYER)
	{
	}

	private void DebugPopulateSignatureAbilityList(List<SignatureAbility> fightModifiers)
	{
	}

	private void PopulateFightConstraints(Fight fight)
	{
	}

	private void PopulateNodeModifiers(Fight fight)
	{
	}

	private PauseScreenModifier CreateNewModifierItem()
	{
		return null;
	}

	private PauseScreenConstraint CreateNewConstraintItem()
	{
		return null;
	}
}
