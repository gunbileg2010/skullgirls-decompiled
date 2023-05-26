using System;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationFontStyle : ScriptableObject
{
	[Serializable]
	public struct FontStyleSettings
	{
		public bool allCaps;
	}

	[Serializable]
	public struct FontStyleOverride
	{
		public Language language;

		public Font font;

		public string fontResource;

		public FontStyleSettings fontSettings;
	}

	[SerializeField]
	private Font defaultFont;

	[SerializeField]
	private FontStyleSettings defaultFontSettings;

	[SerializeField]
	private FontStyleOverride[] overrideFonts;

	private static List<LocalizationFontStyle> enabledFontStyles;

	private static Dictionary<string, Font> loadedFonts;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public Font GetFontForLanguage(Language language)
	{
		return null;
	}

	public unsafe ref FontStyleSettings GetSettingsForLanguage(Language language)
	{
		return ref *(FontStyleSettings*)null;
	}

	public static void UnloadAllDynamicFonts()
	{
	}

	public void UnloadDynamicFonts()
	{
	}
}
