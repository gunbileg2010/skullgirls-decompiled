using System;
using System.Collections.Generic;
using UnityEngine;

public class MasterPopupData : SGUGUIPopupData
{
	public enum BackButtonAction
	{
		Default = 0,
		Ignore = 1,
		Hide = 2
	}

	public float frameWidth;

	public BackButtonAction backButtonAction;

	public MasterPopup.TopFrameType topFrameType;

	public TalkingHead talkingHead;

	public string talkingHeadEmote;

	public MasterPopup.HeaderType headerType;

	public string headerText;

	public string bodyText;

	public ButtonInfo[] buttons;

	public bool useDefaultCloseButton;

	[HideInInspector]
	public string errorCode;

	[HideInInspector]
	public string errorMessage;

	public void SetCurrenciesForButton(int buttonIndex, Currency[] currencies, Dictionary<CurrencyType, Action<CurrencyDisplayUI>> dynamicCurrencies = null)
	{
	}
}
