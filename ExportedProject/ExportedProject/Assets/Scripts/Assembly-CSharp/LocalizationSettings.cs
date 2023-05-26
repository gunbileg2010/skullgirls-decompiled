using System;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationSettings : ScriptableObject
{
	public LocaleData[] supportedLocales;

	public int csvImporterKeywordRowIndex;

	public string assetBundleName;

	[TextArea]
	public string alwaysIncludeGlyphs;

	private static LocalizationSettings instance;

	[NonSerialized]
	private List<LocaleData> availableLocales;

	public static LocalizationSettings GetInstance()
	{
		return null;
	}

	public static void SetInstance(LocalizationSettings settings)
	{
	}

	public List<LocaleData> GetAvailableLocales()
	{
		return null;
	}

	public LocaleData GetLocaleDataForLocaleCode(string localeCode, bool enabledOnly = true, bool fallBackOnDefault = true)
	{
		return null;
	}

	public LocaleData GetLocaleDataForLanguageEnum(Language language)
	{
		return null;
	}
}
