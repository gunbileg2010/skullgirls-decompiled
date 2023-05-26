using UnityEngine;

public class SetGameTypeSequentialAction : SequentialAction
{
	[SerializeField]
	private GameType gameType;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
