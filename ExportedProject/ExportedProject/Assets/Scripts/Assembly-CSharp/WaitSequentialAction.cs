using System.Collections;
using UnityEngine;

public class WaitSequentialAction : SequentialAction
{
	[SerializeField]
	private float length;

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
