using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LocaleData
{
	public string name;

	public string localizedName;

	public Language language;

	public DynamicResource dynamicLanguageSprite;

	public string primaryLocale;

	public string[] additionalLocales;

	public bool enabled;

	public string GetLocalizationFilename()
	{
		return null;
	}

	public bool IsExactMatchForLocaleCode(string localeCode)
	{
		return false;
	}

	public bool IsPartialMatchForLocaleCode(string localeCode)
	{
		return false;
	}

	public Dictionary<string, object> LoadTranslations(Func<string, TextAsset> loadTextAsset)
	{
		return null;
	}
}
