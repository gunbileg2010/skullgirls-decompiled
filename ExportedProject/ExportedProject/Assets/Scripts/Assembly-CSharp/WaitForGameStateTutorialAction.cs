using System.Collections;
using UnityEngine;

public class WaitForGameStateTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	private string stateName;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private IEnumerator WaitForGameState()
	{
		return null;
	}
}
