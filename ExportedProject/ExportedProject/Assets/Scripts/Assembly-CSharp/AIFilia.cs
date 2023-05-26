using System.Collections;

public class AIFilia : AICharacter
{
	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBTrichobezoar(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBFenrir(GearStatusTracker gearTracker)
	{
		return null;
	}

	public override float GetDefendChanceMultiplier(float diff)
	{
		return 0f;
	}

	public override bool ShouldPerformDefensiveCharacterAbility()
	{
		return false;
	}

	public override IEnumerator PerformDefensiveCharacterAbility()
	{
		return null;
	}
}
