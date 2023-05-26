using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterConstraint : FightConstraint
{
	[SerializeField]
	private BaseCharacterData[] charactersNeeded;

	public BaseCharacterData[] GetBaseCharactersNeeded()
	{
		return null;
	}

	public override List<FightConstraintUI> GenerateConstraintIcons(FightConstraintUI prototype, Fight fight)
	{
		return null;
	}

	public override void CheckCharactersMeetConstraint(List<Character> characters, Action<Character> failCallback)
	{
	}

	public static int CheckCharactersMeetConstraint(BaseCharacterData[] charactersNeeded, bool inverted, List<Character> characters, Action<Character> failCallback)
	{
		return 0;
	}

	public override bool IsCharacterExcluded(Character character, int maxTeamSize)
	{
		return false;
	}

	public List<object> GetServerUploadData()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public Dictionary<BaseCharacterData, int> GetBaseCharacterCounts()
	{
		return null;
	}

	public static Dictionary<BaseCharacterData, int> GetBaseCharacterCounts(BaseCharacterData[] charactersNeeded, bool inverted)
	{
		return null;
	}

	protected override bool CheckConstraint(List<Character> team)
	{
		return false;
	}
}
