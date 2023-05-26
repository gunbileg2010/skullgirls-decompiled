using System.Collections;

public class AIBigBand : AICharacter
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

	protected IEnumerator BBSupersonic(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBTympani(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBBeatExtend(GearStatusTracker gearTracker)
	{
		return null;
	}
}
