using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class LocalizedUGUIText : MonoBehaviour, ILocalized
{
	[Serializable]
	public struct Settings
	{
		public Language language;

		public int fontSize;

		public float lineSpacing;

		public float letterSpacing;

		public Settings(Language language)
		{
		}

		public bool Initialized()
		{
			return false;
		}
	}

	[SerializeField]
	private string localizationKey;

	[SerializeField]
	private LocalizationFontStyle fontStyle;

	[SerializeField]
	private List<Settings> overrides;

	private Text uguiText;

	private Settings defaultSettings;

	private LetterSpacing letterSpacing;

	private Dictionary<string, object> subs;

	private Language currentLanguage;

	public Text text => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshLocalization()
	{
	}

	public void SetTranslation(string newKeyOrText)
	{
	}

	public string GetLocKey()
	{
		return null;
	}

	public void AddSub(string subKey, object subValue)
	{
	}

	public void RemoveSub(string subKey)
	{
	}

	public void ClearSubs()
	{
	}

	private void RefreshLocalization(string translation, Language language)
	{
	}

	private string ApplySubs(string original)
	{
		return null;
	}

	private void UpdateFontFromFontStyle(Language language)
	{
	}

	private void SaveSettings(ref Settings settings)
	{
	}

	private void ApplySettings(ref Settings settings)
	{
	}
}
