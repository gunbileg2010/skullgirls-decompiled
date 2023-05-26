using System.Collections.Generic;
using UnityEngine;

public class SeedTeam : GuidScriptableObject, IServerUploadable
{
	public enum SeedTeamType
	{
		RankedPlay = 0,
		Versus = 1
	}

	[SerializeField]
	private int score;

	[SerializeField]
	private string teamName;

	[SerializeField]
	private SeedTeamType teamSeedType;

	[SerializeField]
	private List<CharacterGenerator> characterGenerators;

	public int GetScore()
	{
		return 0;
	}

	public string GetName()
	{
		return null;
	}

	public List<CharacterGenerator> GetGenerators()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
