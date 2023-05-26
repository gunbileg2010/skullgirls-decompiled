using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FightConstraint : ScriptableObject
{
	[SerializeField]
	protected string constraintTitle;

	[SerializeField]
	protected string constraintDescription;

	[SerializeField]
	protected bool inverted;

	public bool IsConstraintMet(List<Character> team)
	{
		return false;
	}

	public virtual List<FightConstraintUI> GenerateConstraintIcons(FightConstraintUI prototype, Fight fight)
	{
		return null;
	}

	public virtual void CheckCharactersMeetConstraint(List<Character> characters, Action<Character> failCallback)
	{
	}

	public virtual bool IsCharacterExcluded(Character character, int maxTeamSize)
	{
		return false;
	}

	public string GetTitle()
	{
		return null;
	}

	public bool IsInverted()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	protected virtual bool CheckConstraint(List<Character> team)
	{
		return false;
	}
}
