using UnityEngine;
using UnityEngine.UI;

public class FavoriteButtonController : MonoBehaviour
{
	[SerializeField]
	private CharacterCardRarityElement colorChanger;

	[SerializeField]
	private Image frameImage;

	[SerializeField]
	private Image fillImage;

	[SerializeField]
	private Sprite regularFrame;

	[SerializeField]
	private Sprite regularFill;

	[SerializeField]
	private Sprite diamondFrame;

	[SerializeField]
	private Sprite diamondFill;

	private RarityTier tier;

	private Element element;

	public void SetRarity(RarityTier newTier, Element newElement)
	{
	}
}
