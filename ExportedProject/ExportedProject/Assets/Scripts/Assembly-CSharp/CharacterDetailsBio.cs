using UnityEngine;
using UnityEngine.UI;

public class CharacterDetailsBio : UGUIPopup
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private LocalizedUGUIText nameLocalizedText;

	[SerializeField]
	private LocalizedUGUIText bioLocalizedText;

	[SerializeField]
	private LocalizedUGUIText birthdayLocalizedText;

	[SerializeField]
	private LocalizedUGUIText bloodTypeLocalizedText;

	[SerializeField]
	private LocalizedUGUIText heightLocalizedText;

	[SerializeField]
	private LocalizedUGUIText weightLocalizedText;

	[SerializeField]
	private LocalizedUGUIText likesLocalizedText;

	[SerializeField]
	private LocalizedUGUIText dislikesLocalizedText;

	private BaseCharacterData baseData;

	public override void SetData(PopupData newPopupData)
	{
	}
}
