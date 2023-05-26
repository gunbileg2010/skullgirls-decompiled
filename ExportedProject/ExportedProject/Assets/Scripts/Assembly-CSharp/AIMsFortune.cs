using System.Collections;

public class AIMsFortune : AICharacter
{
	private Actor myHead;

	private AIOptions headOptions;

	private int extraHeadCooldownFrames;

	private const int kDefaultExtraHeadCooldownFrames = 7;

	public override void Init(AIInputProvider aiInputProvider)
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

	public override bool ShouldPerformDefensiveCharacterAbility()
	{
		return false;
	}

	public override IEnumerator PerformDefensiveCharacterAbility()
	{
		return null;
	}

	public override IEnumerator RunChildStepNormal()
	{
		return null;
	}

	private bool ShouldPerformHeadActions()
	{
		return false;
	}

	private IEnumerator PerformHeadActions()
	{
		return null;
	}

	private bool ShouldRemoveHead()
	{
		return false;
	}

	private IEnumerator RemoveHead()
	{
		return null;
	}

	private void FindHead()
	{
	}

	private IEnumerator FelineAllergies()
	{
		return null;
	}

	private IEnumerator Headbutt()
	{
		return null;
	}

	private IEnumerator Zoom()
	{
		return null;
	}

	private IEnumerator RecallHead()
	{
		return null;
	}
}
