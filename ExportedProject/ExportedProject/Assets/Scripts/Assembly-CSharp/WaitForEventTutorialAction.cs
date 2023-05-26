using UnityEngine;

public class WaitForEventTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	private string eventName;

	[SerializeField]
	private int repetitions;

	private int progress;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private void OnEventFired(object passed)
	{
	}
}
