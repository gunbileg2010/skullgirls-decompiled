using UnityEngine;

public class StartFightSequentialAction : SequentialAction
{
	[SerializeField]
	private bool isOfflineFight;

	[SerializeField]
	private Fight fight;

	[SerializeField]
	private Act act;

	[SerializeField]
	private Chapter chapter;

	[SerializeField]
	private SGMatch match;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
