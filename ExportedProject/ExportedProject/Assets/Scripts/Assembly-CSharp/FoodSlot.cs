using UnityEngine;
using UnityEngine.UI;

public class FoodSlot : MonoBehaviour
{
	[SerializeField]
	private Transform cardAnchor;

	[SerializeField]
	private GameObject checkmark;

	[SerializeField]
	private GameObject skillPointsGO;

	[SerializeField]
	private Text skillPointsLabel;

	[SerializeField]
	private Image skillPointsIcon;

	private CharacterCard card;

	private void Awake()
	{
	}

	public void SetFood(CharacterCard card)
	{
	}

	public void ReturnFood()
	{
	}

	public Character GetCharacter()
	{
		return null;
	}

	public long GetXpGainFromEatingSlot(Character characterWhoIsEating)
	{
		return 0L;
	}
}
