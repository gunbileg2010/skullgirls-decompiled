using System.Collections;

public class AIAnnie : AICharacter
{
	private const int kMinDistanceToActivateCA = 550;

	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	public override bool ShouldPerformOffensiveCharacterAbility()
	{
		return false;
	}

	public override IEnumerator PerformOffensiveCharacterAbility()
	{
		return null;
	}

	private IEnumerator GearSwipeForwardSpam(GearStatusTracker gearTracker, int frames)
	{
		return null;
	}

	private IEnumerator SwipeForwardSpam(int frames)
	{
		return null;
	}
}
