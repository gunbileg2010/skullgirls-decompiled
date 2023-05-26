using System.Collections;

public class AISquigly : AICharacter
{
	public override void Init(AIInputProvider aiInputProvider)
	{
	}

	public override void Stop()
	{
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
