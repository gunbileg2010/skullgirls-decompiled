using System.Collections;

public class AIBeowulf : AICharacter
{
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

	protected IEnumerator BBSuperThrow(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBAirwulf(GearStatusTracker gearTracker)
	{
		return null;
	}
}
