using UnityEngine;

public class ChangeAISequentialAction : SequentialAction
{
	[SerializeField]
	private AIProfile aiProfile;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
