using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguagePicker : SGUGUIPopup
{
	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private ToggleGroup languageToggleGroup;

	[SerializeField]
	private Toggle languageItemPrototype;

	private List<LocaleData> availableLocales;

	private Toggle[] languageToggles;

	private bool ftueActive;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_LanguageSelectionChanged(bool value)
	{
	}
}
