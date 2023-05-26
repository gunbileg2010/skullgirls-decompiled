using UnityEngine;

public class InputFilterSequentialAction : SequentialAction
{
	private enum InputFilterMode
	{
		Add = 0,
		Remove = 1
	}

	[SerializeField]
	private InputFilterMode filterMode;

	[SerializeField]
	private bool tap;

	[SerializeField]
	private bool touch1F;

	[SerializeField]
	private bool swipeUp;

	[SerializeField]
	private bool swipeDown;

	[SerializeField]
	private bool swipeLeft;

	[SerializeField]
	private bool swipeRight;

	[SerializeField]
	private bool touch2F;

	[SerializeField]
	private bool swipe2F;

	[SerializeField]
	private bool tagIn1;

	[SerializeField]
	private bool tagIn2;

	private int inputMask;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
