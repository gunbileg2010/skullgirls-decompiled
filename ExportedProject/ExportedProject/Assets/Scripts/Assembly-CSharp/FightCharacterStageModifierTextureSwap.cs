using System;
using System.Collections.Generic;
using UnityEngine;

public class FightCharacterStageModifierTextureSwap : FightCharacterStageModifier
{
	[Serializable]
	private class CharacterTexture
	{
		public DynamicResource texture;

		public CharacterSortAndFilter.FilterMask characterFilterMask;
	}

	[SerializeField]
	private int characterIndex;

	[SerializeField]
	private bool useP2;

	[SerializeField]
	private List<CharacterTexture> characterTextures;

	private DynamicResource resource;

	public override void SetInFightCharacters(List<Character> playerTeam, List<Character> enemyTeam)
	{
	}

	public override void Cleanup()
	{
	}

	private DynamicResource GetTextureForCharacter(Character character)
	{
		return null;
	}
}
