using System;
using System.Collections.Generic;

[Serializable]
public class FightRequirement
{
	public int energyRequirement;

	public FightConstraint[] fightConstraints;

	public int playerMaxTeamSize;

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public static void AddFightConstraintData(Dictionary<string, object> data, FightConstraint[] fightConstraints, bool isDefenseOnly = false)
	{
	}
}
