using UnityEngine;

public class SetMatchPreviewInteractiveSequentialAction : SequentialAction
{
	private enum ButtonFilterMode
	{
		Add = 0,
		Remove = 1
	}

	[SerializeField]
	private ButtonFilterMode filterMode;

	[SerializeField]
	private bool characterDetailsButtons;

	[SerializeField]
	private bool changeTeamButton;

	[SerializeField]
	private bool fightButton;

	[SerializeField]
	private bool elementsButton;

	private int buttonMask;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
