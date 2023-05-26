using UnityEngine;

public class PushGameStateSequentialAction : SequentialAction
{
	[SerializeField]
	private string stateName;

	[SerializeField]
	private bool clearHistory;

	[SerializeField]
	private bool withoutTransition;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
