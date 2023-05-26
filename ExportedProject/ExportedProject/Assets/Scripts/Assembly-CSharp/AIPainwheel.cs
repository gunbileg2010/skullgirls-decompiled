using System.Collections;

public class AIPainwheel : AICharacter
{
	public static readonly uint flightTag;

	public static readonly uint jumpingTag;

	private AIOptions options;

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

	protected IEnumerator BBDeathCrawl(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBBuerThresher(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator BBFractureReaper(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator Dash()
	{
		return null;
	}

	protected IEnumerator Throw()
	{
		return null;
	}

	protected IEnumerator Tap()
	{
		return null;
	}
}
