using System.Collections;

public class AIValentine : AICharacter
{
	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	public override bool ShouldActivateGear(GearData gearData)
	{
		return false;
	}

	private IEnumerator ForbiddenProcedure(GearStatusTracker gearTracker)
	{
		return null;
	}
}
