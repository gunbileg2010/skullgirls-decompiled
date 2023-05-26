using UnityEngine;

public class SetFightWaitStateSequentialAction : SequentialAction
{
	[SerializeField]
	private FightWaitState myWaitState;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
