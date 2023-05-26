using System.Collections;

public class AIEliza : AICharacter
{
	public static readonly uint sekhmetTag;

	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	public override float GetDefendChanceMultiplier(float diff)
	{
		return 0f;
	}
}
