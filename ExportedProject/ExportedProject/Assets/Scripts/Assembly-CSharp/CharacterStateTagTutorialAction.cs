using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateTagTutorialAction : SequentialTutorialAction
{
	public enum TutorialStateTags
	{
		Light1 = 0,
		Light2 = 1,
		Light3 = 2,
		Blocking = 3,
		Launcher = 4,
		DashFwd = 5,
		DashBack = 6,
		Heavy1 = 7,
		Knockback = 8,
		Throw = 9,
		Special = 10,
		Super = 11,
		Attack = 12,
		PBGCFlashOK = 13,
		ChargeExit = 14,
		Jumping = 15,
		TagOut = 16,
		Hitstun = 17,
		Jump3 = 18,
		Idle = 19,
		ThrowTech = 20,
		Trip = 21
	}

	[SerializeField]
	private TutorialStateTags stateTag;

	[SerializeField]
	private List<TutorialStateTags> additionalTags;

	[SerializeField]
	private int repetitions;

	[SerializeField]
	private bool enemy;

	[SerializeField]
	private bool immediate;

	[SerializeField]
	private bool successfulHit;

	[SerializeField]
	private bool clearInputs;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private IEnumerator WaitForState()
	{
		return null;
	}

	private bool HasTags(Actor actor)
	{
		return false;
	}

	private void DisplayProgress(int progress)
	{
	}
}
