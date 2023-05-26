using System.Collections;
using UnityEngine;

public class AutoplayTutorialAction : SequentialTutorialAction
{
	private enum Mode
	{
		Wait = 0,
		Set = 1,
		Restore = 2
	}

	[SerializeField]
	private Mode mode;

	[SerializeField]
	private bool isEnabled;

	[SerializeField]
	private bool saveSetValue;

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
