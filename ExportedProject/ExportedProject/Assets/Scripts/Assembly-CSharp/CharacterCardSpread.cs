using System.Collections.Generic;
using UnityEngine;

public class CharacterCardSpread : MonoBehaviour
{
	[SerializeField]
	private List<VariantCharacterData> variantCharacterDatas;

	[SerializeField]
	private float spacing;

	private List<CharacterCard> cards;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetCharacters(List<VariantCharacterData> variantCharacterDatas)
	{
	}

	public void SetCharacters(List<Character> characters)
	{
	}

	public void CleanUp()
	{
	}

	private void PositionCard(Transform card, int cardIndex)
	{
	}
}
