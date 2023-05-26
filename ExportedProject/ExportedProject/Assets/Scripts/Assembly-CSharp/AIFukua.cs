using System.Collections;

public class AIFukua : AICharacter
{
	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	public override bool ShouldActivateGear(GearData gearData)
	{
		return false;
	}
}
