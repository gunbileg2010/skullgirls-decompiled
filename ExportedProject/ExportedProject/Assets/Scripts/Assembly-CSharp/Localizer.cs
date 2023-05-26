using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class Localizer : MonoSingleton<Localizer>
{
	public const string kAppendKeys = "---";

	public const string kAppendKeysWithSpace = "+++";

	[SerializeField]
	private LocalizationSettings localizationSettings;

	[SerializeField]
	private bool detectSystemLocale;

	[SerializeField]
	private Language defaultLanguage;

	private readonly string[] kAppendKeysArray;

	private readonly string[] kAppendKeysWithSpaceArray;

	private List<ILocalized> localizedElements;

	private Language currentLanguage;

	private Dictionary<string, object> translations;

	private Func<string, TextAsset> loadTextAsset;

	public event Action<Language> LanguageChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	public void SetLoatTextAssetDelegate(Func<string, TextAsset> loadTextAsset)
	{
	}

	public void SetLanguage(string localeCode)
	{
	}

	public void SetLanguage(Language language, bool saveAsPreferred = false)
	{
	}

	public void RefreshCurrentLanguage()
	{
	}

	public Language GetCurrentLanguage()
	{
		return default(Language);
	}

	public LocaleData GetCurrentLocale()
	{
		return null;
	}

	public List<LocaleData> GetAvailableLocales()
	{
		return null;
	}

	public void RegisterLocalized(ILocalized element)
	{
	}

	public void UnregisterLocalized(ILocalized element)
	{
	}

	public string GetTranslation(string key)
	{
		return null;
	}

	public bool HasPreferredLanguage()
	{
		return false;
	}

	private void LoadLocalizationSettings()
	{
	}

	private string GetTranslationInternal(string key, Dictionary<string, object> translationDict)
	{
		return null;
	}

	private void RefreshLocalizedAssets()
	{
	}

	private string GetSystemLocaleCode()
	{
		return null;
	}

	public Localizer()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
