using System.Collections.Generic;
using UnityEngine;

public class FightCharacterStageModifierObjectToggle : FightCharacterStageModifier
{
	[SerializeField]
	private GameObject connectedGameObject;

	[SerializeField]
	private CharacterSortAndFilter.FilterMask characterFilterMask;

	[SerializeField]
	private bool invertOnOff;

	[SerializeField]
	private bool forceOffOutOfFight;

	public void OnEnable()
	{
	}

	public override void SetInFightCharacters(List<Character> playerTeam, List<Character> enemyTeam)
	{
	}
}
