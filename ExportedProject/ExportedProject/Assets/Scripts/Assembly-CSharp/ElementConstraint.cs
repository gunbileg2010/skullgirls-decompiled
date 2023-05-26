using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ElementConstraint : FightConstraint
{
	[SerializeField]
	private Element[] elementsNeeded;

	public override List<FightConstraintUI> GenerateConstraintIcons(FightConstraintUI prototype, Fight fight)
	{
		return null;
	}

	public override void CheckCharactersMeetConstraint(List<Character> characters, Action<Character> failCallback)
	{
	}

	public static int CheckCharactersMeetConstraint(Element[] elementsNeeded, bool inverted, List<Character> characters, Action<Character> failCallback)
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

	public Dictionary<Element, int> GetElementCounts()
	{
		return null;
	}

	public static Dictionary<Element, int> GetElementCounts(Element[] elementsNeeded, bool inverted)
	{
		return null;
	}

	public Element[] GetElementsNeeded()
	{
		return null;
	}

	protected override bool CheckConstraint(List<Character> team)
	{
		return false;
	}
}
