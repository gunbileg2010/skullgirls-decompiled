using System.Collections.Generic;
using UnityEngine;

public class SeedTeamList : ScriptableObject
{
	[SerializeField]
	public List<SeedTeam> seedTeams;

	public List<object> GetServerUploadDataList()
	{
		return null;
	}
}
