using System.Collections;

public class AICerebella : AICharacter
{
	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	public override bool ShouldPerformDefensiveCharacterAbility()
	{
		return false;
	}

	public override IEnumerator PerformDefensiveCharacterAbility()
	{
		return null;
	}

	protected IEnumerator BBArmSkip(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBSuperThrow(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBExcellabella(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBJazzHands(GearStatusTracker gearTracker)
	{
		return null;
	}
}
