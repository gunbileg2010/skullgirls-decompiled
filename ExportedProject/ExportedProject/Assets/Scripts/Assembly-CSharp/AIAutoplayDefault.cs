using System.Collections;

public class AIAutoplayDefault : AIBase
{
	public override IEnumerator StepNormal()
	{
		return null;
	}

	public override IEnumerator StepTagIn()
	{
		return null;
	}

	protected IEnumerator MasterAttack()
	{
		return null;
	}

	protected IEnumerator MasterDefend()
	{
		return null;
	}

	protected IEnumerator LightComboAttack()
	{
		return null;
	}

	protected IEnumerator HeavyComboAttack()
	{
		return null;
	}

	private float AdjustedDiff(float diff, float baseDiff, float baseVal, float delta)
	{
		return 0f;
	}
}
