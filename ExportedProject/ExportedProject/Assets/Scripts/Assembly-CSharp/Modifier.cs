using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Modifier : MonoBehaviour
{
	public string id;

	public int usageLimit;

	[SerializeField]
	protected int stacksOnProc;

	[SerializeField]
	protected ModifierStrength strength;

	[SerializeField]
	protected bool displayHudIcon;

	[SerializeField]
	protected bool affectDamageText;

	[SerializeField]
	protected bool displayStatusText;

	[SerializeField]
	protected bool displayAbilityText;

	[SerializeField]
	protected bool dontClearSATextEarly;

	[SerializeField]
	protected bool shouldTriggerEvent;

	[SerializeField]
	protected bool bypassPrevention;

	[SerializeField]
	[Space]
	protected Fixed duration;

	[SerializeField]
	protected bool isPermanent;

	public TriggerEvent unapplyTriggerEvent;

	public bool unapplyAllStacks;

	public List<Condition> unapplyTriggerConditions;

	public List<Condition> unapplyProvokerConditions;

	public SignatureAbilityTier.ActorFilter provokingActors;

	private static uint instanceIdCounter;

	private static uint instanceIdCounterDown;

	private static Dictionary<uint, Modifier> modifierInstancesByInstanceId;

	private Dictionary<Actor, int> usageCounts;

	protected Modifier templateModifier;

	protected bool isTemplatelessModifier;

	private uint instanceId;

	protected Actor appliedBy;

	protected Actor affectedActor;

	protected int numberStacked;

	protected int maxStacked;

	protected Fixed strengthMultiplier;

	private List<ModifierData> modifierDataQueue;

	private bool isDisabled;

	public ModifierIcon ModifierIcon
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public SignatureAbility SASource
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected virtual void OnDestroy()
	{
	}

	public static void ClearInstanceIdMap()
	{
	}

	public static Modifier GetModifierInstance(uint instanceId)
	{
		return null;
	}

	public void TemplateInit(bool isAssetType, SignatureAbility signatureAbilitySource = null)
	{
	}

	public void Init(Actor actor)
	{
	}

	public void Shutdown()
	{
	}

	public uint GetModifierInstanceId()
	{
		return 0u;
	}

	public virtual ModifierType GetModifierType()
	{
		return default(ModifierType);
	}

	public virtual ModifierStrength GetModifierStrength()
	{
		return default(ModifierStrength);
	}

	public void SetModifierStrength(ModifierStrength modifierStrength)
	{
	}

	public static bool IsBuff(ModifierType modifierType)
	{
		return false;
	}

	public static bool IsDebuff(ModifierType modifierType)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public bool IsPermanent()
	{
		return false;
	}

	public bool ShouldDisplayHUDIcon()
	{
		return false;
	}

	public bool ShouldAffectDamageText()
	{
		return false;
	}

	public bool ShouldDisplayStatusText()
	{
		return false;
	}

	public bool ShouldDisplayAbilityText()
	{
		return false;
	}

	public bool ShouldTriggerEvent()
	{
		return false;
	}

	public bool ShouldBypassPrevention()
	{
		return false;
	}

	public bool ShouldIgnoreSATextClearRequests()
	{
		return false;
	}

	public virtual string GetDisplayName()
	{
		return null;
	}

	public void SetPermanent(bool permanent)
	{
	}

	public virtual void SetDuration(float inDuration)
	{
	}

	public void SetShouldTriggerEvent(bool triggerEvent)
	{
	}

	public void SetShouldBypassPrevention(bool bypass)
	{
	}

	public void SetShouldDisplayAbilityText(bool triggerText)
	{
	}

	public void SetShouldDisplayStatusText(bool statusText)
	{
	}

	public void SetShouldDisplayHUDIcon(bool hudIcon)
	{
	}

	public float GetDuration()
	{
		return 0f;
	}

	public int GetTimer()
	{
		return 0;
	}

	public List<ModifierData> GetModifierDataQueue()
	{
		return null;
	}

	public void GetModifierDataQueue(List<ModifierData> data)
	{
	}

	public int GetNumberStacked()
	{
		return 0;
	}

	public int GetStacksOnProc()
	{
		return 0;
	}

	public void SetStacksOnProc(int stacksOnProc)
	{
	}

	public virtual bool ShouldStackWith(Modifier toStack)
	{
		return false;
	}

	public Dictionary<Actor, int> GetUsageCounts()
	{
		return null;
	}

	public bool IsTemplate()
	{
		return false;
	}

	public Modifier GetTemplateModifier()
	{
		return null;
	}

	public void SetTemplatelessModifier()
	{
	}

	public void Disable(bool fullStack = false)
	{
	}

	public void Enable(bool fullStack = false)
	{
	}

	public static Modifier ApplyModifierTo(Modifier templateModifier, Actor applyTo, Actor applierOfModifier)
	{
		return null;
	}

	public static Modifier ApplyModifierTo(Modifier templateModifier, Actor applyTo, Actor applierOfModifier, out bool wasApplied, TriggerEventData provokingTriggerEventData = null)
	{
		wasApplied = default(bool);
		return null;
	}

	public void RemoveOldestModifierStack(bool removePermanent = false)
	{
	}

	public static string GetTranslatedString(string key)
	{
		return null;
	}

	public virtual List<Modifier> GetInternalModifiers()
	{
		return null;
	}

	public Actor GetAppliedBy()
	{
		return null;
	}

	public static void SaveStateStatic(BinaryWriter writer)
	{
	}

	public virtual void SaveState(BinaryWriter writer)
	{
	}

	public static void LoadStateStatic(BinaryReader reader)
	{
	}

	public virtual void LoadState(BinaryReader reader)
	{
	}

	public virtual bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public void SaveTemplateState(BinaryWriter writer)
	{
	}

	public void SaveTemplateState2(ref ModifierStateData modifierStateData)
	{
	}

	public void LoadTemplateState(BinaryReader reader)
	{
	}

	public bool CompareTemplateState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	protected virtual void Apply()
	{
	}

	protected virtual void ModifierFrameUpdate(object passed)
	{
	}

	protected virtual void OnFrameUpdate()
	{
	}

	protected virtual void Unapply()
	{
	}

	protected virtual void OnModifierDestroy()
	{
	}

	private int Stack(Modifier stackingModifier)
	{
		return 0;
	}

	private void OnUnapplyEvent(object passed)
	{
	}

	private void UpdateTimer(int timerIndex)
	{
	}

	private void CleanupExpiredTimers()
	{
	}

	private void DecrementModifier(bool removePermanent = false)
	{
	}
}
