using UnityEngine;
using UnityEngine.UI;

public class PauseScreenConstraint : MonoBehaviour
{
	[SerializeField]
	private Image tierImage;

	[SerializeField]
	private Sprite[] tierSprites;

	[SerializeField]
	private Image insigniaImage;

	[SerializeField]
	private Image elementImage;

	[SerializeField]
	private Text mainText;

	[SerializeField]
	private Image noImage;

	[SerializeField]
	private GameObject numberGO;

	[SerializeField]
	private Text numberText;

	[HideInInspector]
	public Fight fight;

	public void OnDisable()
	{
	}

	public void SetTierConstraint(RarityTier tier, int count, string text)
	{
	}

	public void SetBaseCharacterConstraint(BaseCharacterData baseCharacterData, int count, string text)
	{
	}

	public void SetElementConstraint(Element element, int count, string text)
	{
	}

	public void UpdateCount(int count)
	{
	}
}
