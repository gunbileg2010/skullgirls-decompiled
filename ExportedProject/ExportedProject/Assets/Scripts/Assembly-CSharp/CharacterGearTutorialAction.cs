using System.Collections;
using UnityEngine;

public class CharacterGearTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	private int gearIndex;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private IEnumerator WaitForGear()
	{
		return null;
	}
}
