using UnityEngine;

public class SetTopBarInteractiveSequentialAction : SequentialAction
{
	private enum ButtonFilterMode
	{
		Add = 0,
		Remove = 1
	}

	[SerializeField]
	private ButtonFilterMode filterMode;

	[SerializeField]
	private bool homeButton;

	[SerializeField]
	private bool profileButton;

	[SerializeField]
	private bool softCurrencyButton;

	[SerializeField]
	private bool hardCurrencyButton;

	[SerializeField]
	private bool settingsButton;

	[SerializeField]
	private bool backButton;

	private int buttonMask;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
