using UnityEngine;
using UnityEngine.UI;

public class MatchModifierUI : MonoBehaviour
{
	[SerializeField]
	private Image modifierIcon;

	[SerializeField]
	private Sprite matchModifierIconSprite;

	[SerializeField]
	private Sprite nodeModifierIconSprite;

	public void Populate(Fight fight, bool showForConstraints = false)
	{
	}
}
