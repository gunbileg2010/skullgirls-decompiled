using System;
using System.Collections;
using System.Collections.Generic;

public class AIBase : AILib
{
	public enum AIState
	{
		None = 0,
		Init = 1,
		Normal = 2,
		TagIn = 3,
		Hitstun = 4,
		Blockstun = 5,
		ThrowTech = 6,
		ChargeDefend = 7,
		Knockdown = 8,
		EnemyDead = 9
	}

	private AIState currentAIState;

	protected AIOptions options;

	private AICoroutines stateCoroutine;

	private AICoroutines extraCoroutines;

	private Dictionary<uint, AICharacter> characterAIs;

	protected Func<IEnumerator>[] gearFuncs;

	private Actor currentPointActor;

	private ZInput aiInputForFrame;

	protected bool respondingToChargeAttack;

	protected bool chargeAttackResponseDecision;

	public override void Init(AIInputProvider aiInputProvider)
	{
	}

	public override void Enable()
	{
	}

	public override void Disable()
	{
	}

	public void Update()
	{
	}

	public virtual IEnumerator StepInit()
	{
		return null;
	}

	public virtual IEnumerator StepNormal()
	{
		return null;
	}

	public virtual IEnumerator StepTagIn()
	{
		return null;
	}

	public virtual IEnumerator StepHitstun()
	{
		return null;
	}

	public virtual IEnumerator StepBlockstun()
	{
		return null;
	}

	public virtual IEnumerator StepThrowTech()
	{
		return null;
	}

	public virtual IEnumerator StepChargeDefend()
	{
		return null;
	}

	public virtual IEnumerator StepKnockedDown()
	{
		return null;
	}

	public virtual IEnumerator StepEnemyDead()
	{
		return null;
	}

	public virtual void CheckIfHitByChargeAttack()
	{
	}

	public virtual void CheckTimeToResetChargeAttackTracker(bool opponentUsingChargeAttack)
	{
	}

	public void DoInput(ZInput input)
	{
	}

	public ZInput GetInput()
	{
		return null;
	}

	public IEnumerator AttackWith(ZInput input, uint hitTag)
	{
		return null;
	}

	protected void AddExtraCoroutine(Func<IEnumerator> coroutine)
	{
	}

	protected void GoToAIState(AIState state)
	{
	}

	protected bool IsInAIState(AIState state)
	{
		return false;
	}

	protected AICharacter GetAICharacter()
	{
		return null;
	}

	private void OnActorWasHit(object context)
	{
	}

	protected void AddCAReactionOptions(float diff)
	{
	}

	protected void AddDahliaCAReactionOptions(float diff, out bool fireLoopOut, out bool otherProjectilesOut)
	{
		fireLoopOut = default(bool);
		otherProjectilesOut = default(bool);
	}

	protected IEnumerator ActivateGear0()
	{
		return null;
	}

	protected IEnumerator ActivateGear1()
	{
		return null;
	}

	protected IEnumerator ActivateGear2()
	{
		return null;
	}

	protected IEnumerator ActivateGear3()
	{
		return null;
	}

	protected IEnumerator ActivateGear4()
	{
		return null;
	}

	protected IEnumerator TripAttack()
	{
		return null;
	}

	protected IEnumerator ThrowAttack()
	{
		return null;
	}

	protected IEnumerator HeavyAttack()
	{
		return null;
	}

	protected IEnumerator LightAttack()
	{
		return null;
	}

	protected IEnumerator DashCancelToBlock()
	{
		return null;
	}

	protected IEnumerator DashCancelToLauncher()
	{
		return null;
	}

	protected IEnumerator ChargeAttack()
	{
		return null;
	}

	protected IEnumerator LauncherAttack()
	{
		return null;
	}

	protected IEnumerator LauncherCombo()
	{
		return null;
	}

	protected IEnumerator DashBack()
	{
		return null;
	}

	protected IEnumerator DashForward()
	{
		return null;
	}

	protected IEnumerator DefaultBlock()
	{
		return null;
	}

	protected IEnumerator BlockFrames(int frames)
	{
		return null;
	}

	protected IEnumerator BlockCustom(int baseFrames, int minRandom, int maxRandom)
	{
		return null;
	}

	protected IEnumerator TagToA1()
	{
		return null;
	}

	protected IEnumerator TagToA2()
	{
		return null;
	}
}
