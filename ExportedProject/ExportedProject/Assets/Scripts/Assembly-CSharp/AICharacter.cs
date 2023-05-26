using System.Collections;

public class AICharacter : AILib
{
	private bool setupTypeGearOK;

	protected AIBase myAIBase;

	public override void Init(AIInputProvider aiInputProvider)
	{
	}

	public virtual void Stop()
	{
	}

	public virtual void OnAIStateChanged(AIBase.AIState newState)
	{
	}

	public virtual IEnumerator RunChildStepNormal()
	{
		return null;
	}

	public void SetAIBase(AIBase aiBase)
	{
	}

	public IEnumerator ActivateGear(int index)
	{
		return null;
	}

	public virtual IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	public void EnableSetupTypeGear()
	{
	}

	public IEnumerator PreActivateGearWithSetupUsageType()
	{
		return null;
	}

	public virtual float GetDefendChanceMultiplier(float diff)
	{
		return 0f;
	}

	public virtual bool ShouldPerformDefensiveCharacterAbility()
	{
		return false;
	}

	public virtual bool ShouldPerformOffensiveCharacterAbility()
	{
		return false;
	}

	public virtual bool ShouldActivatePrestigeAbility()
	{
		return false;
	}

	public virtual IEnumerator PerformOffensiveCharacterAbility()
	{
		return null;
	}

	public virtual IEnumerator PerformDefensiveCharacterAbility()
	{
		return null;
	}

	public IEnumerator ActivatePrestigeAbility()
	{
		return null;
	}

	public virtual bool ShouldActivateGear(GearData gearData)
	{
		return false;
	}

	public bool ShouldActivateGearByUsageType(GearUsageType usageType)
	{
		return false;
	}

	protected void DoInput(ZInput input)
	{
	}

	protected IEnumerator AttackWith(ZInput input, uint hitTag)
	{
		return null;
	}

	protected IEnumerator GearTapSpam(GearStatusTracker gearTracker, int frames)
	{
		return null;
	}

	protected IEnumerator TapSpam(int frames)
	{
		return null;
	}

	protected IEnumerator GearGeneric(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator GearDashInDefault(GearStatusTracker gearTracker)
	{
		return null;
	}

	protected IEnumerator GearDashIn(GearStatusTracker gearTracker, float dist, int waitFrames)
	{
		return null;
	}

	protected bool ShouldActivateSetupGear(Actor enemy)
	{
		return false;
	}
}
