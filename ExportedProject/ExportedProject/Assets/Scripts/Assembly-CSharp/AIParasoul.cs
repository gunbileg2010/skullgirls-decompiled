using System.Collections;

public class AIParasoul : AICharacter
{
	private int numTearsActive;

	private float chancePerTear;

	public override void Init(AIInputProvider aiInputProvider)
	{
	}

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

	private IEnumerator NapalmShower(GearStatusTracker gearTracker)
	{
		return null;
	}

	private IEnumerator ChargeAttack()
	{
		return null;
	}
}
