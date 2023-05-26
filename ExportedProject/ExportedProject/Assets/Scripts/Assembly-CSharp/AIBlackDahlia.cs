using System.Collections;

public class AIBlackDahlia : AICharacter
{
	public static readonly uint fireLoopTag;

	public static readonly uint fireShotTag;

	private bool willReload;

	private bool willShoot;

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

	private bool ShouldReload(float xDist, int ammoCount, bool airborne)
	{
		return false;
	}

	private bool ShouldShoot(float xDist, int ammoCount, bool airborne)
	{
		return false;
	}

	private IEnumerator Shoot()
	{
		return null;
	}

	private IEnumerator Reload()
	{
		return null;
	}
}
