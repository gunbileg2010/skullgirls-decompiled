using System.Collections;

public class AITutorialFTUEEverything : AIBase
{
	private float maxPatience;

	private float patience;

	private bool distanceDelayOK;

	private float rage;

	private float rageUp;

	private float rageDown;

	private float rageMult;

	private const float kMaxRageMult = 4f;

	private float initThrowGrip;

	private float throwGrip;

	private float baseThrowResist;

	private float throwResist;

	public override IEnumerator StepInit()
	{
		return null;
	}

	private void CheckTagOut(Actor pt)
	{
	}

	public override IEnumerator StepNormal()
	{
		return null;
	}

	public override IEnumerator StepHitstun()
	{
		return null;
	}

	public override IEnumerator StepTagIn()
	{
		return null;
	}

	public IEnumerator UpdateTicker()
	{
		return null;
	}

	public override void SetDifficulty(int diff)
	{
	}

	private IEnumerator MasterDefend()
	{
		return null;
	}

	public override IEnumerator StepThrowTech()
	{
		return null;
	}

	private IEnumerator MasterAttack()
	{
		return null;
	}

	private void AddGearAsOption(Actor pt, Actor e, float xdiff)
	{
	}

	private IEnumerator BeVulnerable()
	{
		return null;
	}

	private IEnumerator Whiff()
	{
		return null;
	}

	private IEnumerator LightComboAttack()
	{
		return null;
	}

	private IEnumerator CloseAttack()
	{
		return null;
	}

	private bool HasPunishableTag(Actor actor)
	{
		return false;
	}

	private IEnumerator CustomBlock()
	{
		return null;
	}

	private IEnumerator DashAttack()
	{
		return null;
	}

	private float GetFarPercent()
	{
		return 0f;
	}

	protected void AttemptTagOut()
	{
	}
}
