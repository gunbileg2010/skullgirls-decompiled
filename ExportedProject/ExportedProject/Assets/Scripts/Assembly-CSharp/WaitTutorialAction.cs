using System.Collections;
using UnityEngine;

public class WaitTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	protected float length;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private IEnumerator Wait()
	{
		return null;
	}
}
