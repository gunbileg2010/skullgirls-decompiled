using UnityEngine;
using UnityEngine.UI;

public class GearPipsUI : MonoBehaviour
{
	[SerializeField]
	private Image[] pips;

	[SerializeField]
	private Sprite lockedSprite;

	[SerializeField]
	private Sprite emptySprite;

	[SerializeField]
	private Sprite filledSprite;

	public void Populate(Character character)
	{
	}
}
