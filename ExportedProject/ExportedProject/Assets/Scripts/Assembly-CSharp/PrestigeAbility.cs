using System.IO;
using UnityEngine;

public class PrestigeAbility : MonoBehaviour
{
	[SerializeField]
	protected string title;

	[SerializeField]
	protected string description;

	[SerializeField]
	protected Fixed chargePerAction;

	public static Fixed kMaxChargePercent;

	public const int kMaxLevel = 100;

	[SerializeField]
	private Fixed baseBonus;

	[SerializeField]
	private FixedFraction bonusPerLevels;

	[SerializeField]
	private Fixed maxLevelBonus;

	protected Actor assignedActor;

	protected Fixed chargePercent;

	protected bool activated;

	protected bool lastFrameInPrestigeState;

	private static int instanceIdCounter;

	private int instanceId;

	private static GameObject staticVFX;

	private GameObject vfxReference;

	private int level;

	protected object[] subsitutions;

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public virtual void Init(Actor actor, int level)
	{
	}

	public static void ResetInstanceIdCounter()
	{
	}

	public int GetPAInstanceId()
	{
		return 0;
	}

	public void SetAssignedActor(Actor actor)
	{
	}

	public Actor GetAssignedActor()
	{
		return null;
	}

	public string GetTitle()
	{
		return null;
	}

	public string GetDescription(int level, Color digitColor)
	{
		return null;
	}

	public Fixed GetChargePercent()
	{
		return default(Fixed);
	}

	public virtual void SaveState(BinaryWriter writer)
	{
	}

	public virtual void LoadState(BinaryReader reader)
	{
	}

	public virtual bool CompareState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public bool CanActivate()
	{
		return false;
	}

	public bool HasActivated()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	protected virtual object[] GetDescriptionSubstitutions()
	{
		return null;
	}

	protected virtual void SetupChargeEventListeners()
	{
	}

	protected virtual void CleanUpChargeEventListeners()
	{
	}

	protected virtual void SetupEffectListeners()
	{
	}

	protected virtual void CleanUpEffectListeners()
	{
	}

	protected virtual void ApplyImmediateEffects()
	{
	}

	protected virtual void ApplyEffects()
	{
	}

	protected virtual void UnapplyEffects()
	{
	}

	protected virtual void ActivateAbility()
	{
	}

	private void ActivationListener(object passed)
	{
	}

	private void VFXListener(object passed)
	{
	}

	protected void ChargeAbility()
	{
	}

	protected void ChargeAbility(Fixed chargeToGrant)
	{
	}

	protected Fixed CalculateBonus()
	{
		return default(Fixed);
	}

	private void SetupVFX()
	{
	}

	private void CleanupVFX()
	{
	}
}
