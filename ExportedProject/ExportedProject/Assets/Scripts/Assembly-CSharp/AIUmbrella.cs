using System.Collections;

public class AIUmbrella : AICharacter
{
	private const int kCutiePatooieBubbleOut = 14;

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
}
