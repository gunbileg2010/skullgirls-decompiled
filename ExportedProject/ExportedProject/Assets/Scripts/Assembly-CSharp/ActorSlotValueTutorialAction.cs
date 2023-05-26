using System.Collections;
using UnityEngine;

public class ActorSlotValueTutorialAction : SequentialTutorialAction
{
	private enum Mode
	{
		Wait = 0,
		Set = 1
	}

	[SerializeField]
	private Mode mode;

	[SerializeField]
	private string slotString;

	[SerializeField]
	private float value;

	[SerializeField]
	private bool enemy;

	[SerializeField]
	private bool teammates;

	[SerializeField]
	private int repetitions;

	[SerializeField]
	private bool immediate;

	private Actor actor;

	private Slot slot;

	private SlotValueHolder svh;

	private bool metValue;

	private int timesMet;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private void SetValue()
	{
	}

	private void WaitForValue()
	{
	}

	private IEnumerator CompleteAction()
	{
		return null;
	}

	protected override void FinishAction()
	{
	}

	private void DisplayProgress(int progress)
	{
	}
}
