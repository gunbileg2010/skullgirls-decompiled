using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPowerUpPopup : SGUGUIPopup
{
	public class CharacterPowerUpPopupContext
	{
		public Character currentCharacter;

		public List<Character> foodCharacters;

		public CharacterPowerUpPopupContext(Character currentCharacter, List<Character> foodCharacters)
		{
		}
	}

	[SerializeField]
	private Transform cardsAnchor;

	private Character currentCharacter;

	private List<Character> foodCharacters;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public new void UGUI_PositiveButtonPressed()
	{
	}

	private void ShowRareSacrificeWarningIfNeeded(Action callback, Action cancelCallback)
	{
	}
}
