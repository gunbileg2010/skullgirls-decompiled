using UnityEngine;

public class AddAbilityTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	private SignatureAbility ability;

	[SerializeField]
	private bool enemy;

	private Actor actor;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
