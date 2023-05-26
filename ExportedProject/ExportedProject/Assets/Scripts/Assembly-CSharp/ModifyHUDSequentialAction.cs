using UnityEngine;

public class ModifyHUDSequentialAction : SequentialAction
{
	private enum ModifyHUDMode
	{
		Visibility = 0,
		Interactivity = 1
	}

	[SerializeField]
	private ModifyHUDMode mode;

	[SerializeField]
	private HUDElement HUDElement;

	[SerializeField]
	private bool active;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
