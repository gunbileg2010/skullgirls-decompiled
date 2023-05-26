using UnityEngine;

public class SetSplashScreenInteractiveSequentialAction : SequentialAction
{
	private enum ButtonFilterMode
	{
		Add = 0,
		Remove = 1
	}

	[SerializeField]
	private ButtonFilterMode filterMode;

	[SerializeField]
	private bool storyButton;

	[SerializeField]
	private bool versusButton;

	[SerializeField]
	private bool eventsButton;

	[SerializeField]
	private bool gachaButton;

	[SerializeField]
	private bool collectionButton;

	[SerializeField]
	private bool storeButton;

	[SerializeField]
	private bool challengesButton;

	[SerializeField]
	private bool mailButton;

	[SerializeField]
	private bool practiceButton;

	[SerializeField]
	private bool inventoryButton;

	[SerializeField]
	private bool socialButton;

	[SerializeField]
	private bool syncPvpButton;

	[SerializeField]
	private bool calendarButton;

	[SerializeField]
	private bool riftButton;

	private int buttonMask;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
