using System.Collections.Generic;
using UnityEngine;

public class FightCharacterStageModifier : MonoBehaviour
{
	public void OnDestroy()
	{
	}

	public virtual void SetInFightCharacters(List<Character> playerTeamn, List<Character> enemyTeam)
	{
	}

	public virtual void Cleanup()
	{
	}
}
