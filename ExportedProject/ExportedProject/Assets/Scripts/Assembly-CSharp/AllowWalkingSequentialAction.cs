using UnityEngine;

public class AllowWalkingSequentialAction : SequentialAction
{
	[SerializeField]
	private bool walkingEnabled;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
