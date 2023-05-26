using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TierConstraint : FightConstraint
{
	[SerializeField]
	private RarityTier[] tiersNeeded;

	public override List<FightConstraintUI> GenerateConstraintIcons(FightConstraintUI prototype, Fight fight)
	{
		return null;
	}

	public override void CheckCharactersMeetConstraint(List<Character> characters, Action<Character> failCallback)
	{
	}

	public static int CheckCharactersMeetConstraint(RarityTier[] tiersNeeded, bool inverted, List<Character> characters, Action<Character> failCallback)
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

	public RarityTier[] GetTiersNeeded()
	{
		return null;
	}

	public Dictionary<RarityTier, int> GetTierCounts()
	{
		return null;
	}

	public static Dictionary<RarityTier, int> GetTierCounts(RarityTier[] tiersNeeded, bool inverted)
	{
		return null;
	}

	protected override bool CheckConstraint(List<Character> team)
	{
		return false;
	}
}
