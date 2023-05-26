using System.Collections;

public class AIEnemyDefault : AIBase
{
	private float maxPatience;

	private float patience;

	private bool distanceDelayOK;

	private float rage;

	private const float rageUp = 1f / 60f;

	private const float rageDown = 0.0027777778f;

	private const float kMaxRageMult = 4f;

	private const float initThrowGrip = 100f;

	private float throwGrip;

	private float baseThrowResist;

	private const float kMaxThrowResist = 10f;

	private float throwResist;

	private const float kThrowResistOverageDecay = 0.02f;

	private const float kThrowResistOverageDecayBlockstunMultiplier = 0.25f;

	private int recentBlockstunFrameTimer;

	private int recentBlockstunTimerLength;

	private float timeSpentInBlockstun;

	private const float kMinBlockstunTimeBeforeCounter = 1.5f;

	private const float kBlockstunTimeBeforeMaxCounterOdds = 5.5f;

	private int timesHitByChargeAttack;

	private const int kChargeAttackHitSoonFlag = 43;

	private const float kTagOutPercentReductionPerBuff = 10f;

	private const float kTagOutPercentIncreasePerDebuff = 10f;

	public override IEnumerator StepInit()
	{
		return null;
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

	public override void CheckIfHitByChargeAttack()
	{
	}

	public override void CheckTimeToResetChargeAttackTracker(bool opponentUsingChargeAttack)
	{
	}

	public bool ShouldRespondToChargeAttack()
	{
		return false;
	}

	public override IEnumerator StepChargeDefend()
	{
		return null;
	}

	public void AddViableReversalOptions()
	{
	}

	public override IEnumerator StepThrowTech()
	{
		return null;
	}

	public override IEnumerator StepEnemyDead()
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

	private IEnumerator MasterAttack()
	{
		return null;
	}

	private void AddGearAsOption(Actor pt, Actor e, float xdiff, bool knockdownOk = false, bool overideSuperIsViable = false)
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

	private IEnumerator ShortBlock()
	{
		return null;
	}

	private IEnumerator DashAttack()
	{
		return null;
	}

	private IEnumerator DashCancelToGear()
	{
		return null;
	}

	private float GetFarPercent()
	{
		return 0f;
	}

	private void CheckTagOut(Actor pt)
	{
	}

	private void AttemptTagOut()
	{
	}
}
