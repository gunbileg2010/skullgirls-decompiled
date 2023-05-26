using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterEvolutionView : MonoBehaviour
{
	public enum EvolveStatType
	{
		None = 0,
		Tier = 1,
		MaxLevel = 2,
		MaxFighterScore = 3,
		MaxGearPoints = 4,
		Level = 5,
		Health = 6,
		Attack = 7,
		Prestige = 8
	}

	[Serializable]
	public class EvolveStat
	{
		[HideInInspector]
		public string name;

		public EvolveStatType type;

		public Text current;

		public Text next;
	}

	[SerializeField]
	private Transform currentCardAnchor;

	[SerializeField]
	private Transform nextCardAnchor;

	[SerializeField]
	private AdvancedButton confirmButton;

	[SerializeField]
	private LocalizedUGUIText requirementText;

	[SerializeField]
	private LocalizedUGUIText detailedRequirementsText;

	[SerializeField]
	private List<EvolveStat> evolutionStats;

	private CharacterCard currentCard;

	private CharacterCard nextCard;

	private void OnValidate()
	{
	}

	public void ReturnCharacterCards()
	{
	}

	public void Populate(Character character, int prestigeGain = 0)
	{
	}

	public void SetDetailedRequirements(string detailedRequirements)
	{
	}

	public AdvancedButton GetConfirmationButton()
	{
		return null;
	}

	private void SetStatValues(EvolveStat stat, Character currentCharacter, RarityTier currentTier, int currentLevelCap, RarityTier nextTier, int nextLevelCap, int prestigeGain)
	{
	}
}
