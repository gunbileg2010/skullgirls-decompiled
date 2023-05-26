using System;
using UnityEngine;

public class CharacterConvertPopup : SGUGUIPopup
{
	public class ConversionPopupContext
	{
		public Character characterToConvert;

		public Action<IPopup> successfullyConvertedCallback;

		public ConversionPopupContext(Character characterToConvert, Action<IPopup> successfullyConvertedCallback)
		{
		}
	}

	[SerializeField]
	private Transform currentCardAnchor;

	[SerializeField]
	private CurrencyRewardIcon essenceIcon;

	[SerializeField]
	private CurrencyRewardIcon skillPointsIcon;

	[SerializeField]
	private CurrencyRewardIcon shardIcon;

	private Character characterToConvert;

	private CharacterCard currentCard;

	private Action<IPopup> successfullyConvertedCallback;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}
}
