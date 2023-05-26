using System.Collections;
using UnityEngine;

public class ActorInputSequentialAction : SequentialTutorialAction
{
	private enum Mode
	{
		Queue = 0,
		Wait = 1
	}

	[SerializeField]
	private Mode mode;

	[SerializeField]
	private ZButton input;

	[SerializeField]
	private bool enemy;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private IEnumerator WaitForInput(Controller controller)
	{
		return null;
	}
}
