using System.Collections.Generic;
using UnityEngine;

public class StageSet : ScriptableObject
{
	[SerializeField]
	private bool sequential;

	[SerializeField]
	private List<Stage> stages;

	private int index;

	public Stage GetStage()
	{
		return null;
	}

	public List<Stage> GetStages()
	{
		return null;
	}

	private Stage GetRandomStage()
	{
		return null;
	}

	private Stage GetSequentialStage()
	{
		return null;
	}
}
