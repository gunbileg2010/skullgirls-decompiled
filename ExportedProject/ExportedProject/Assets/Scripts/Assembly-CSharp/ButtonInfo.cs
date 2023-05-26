using System;
using System.Collections.Generic;

[Serializable]
public class ButtonInfo
{
	public string text;

	public ButtonType visualButtonType;

	public PopupButtonType popupActionType;

	public Currency[] currencies;

	public Dictionary<CurrencyType, Action<CurrencyDisplayUI>> dynamicCurrencies;
}
