using UnityEngine;
using UnityEngine.UI;

public class LanguagePickerItem : MonoBehaviour
{
	[SerializeField]
	private Image flagImage;

	[SerializeField]
	private LocalizedUGUIText languageNameText;

	private DynamicResource dynamicResourceRef;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Populate(LocaleData locale)
	{
	}
}
