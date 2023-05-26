using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Actor : MonoBehaviour
{
	public class CollisionData
	{
		public Fixed3 position;

		public FixedBounds bounds;

		public bool collisionEnabled;

		public void Reset()
		{
		}

		public void SaveState(BinaryWriter writer)
		{
		}

		public void LoadState(BinaryReader reader)
		{
		}
	}

	public class CollisionTriggerData
	{
		public Actor attacker;

		public Actor victim;

		public bool blocked;

		public CollisionTriggerData(Actor attacker, Actor victim, bool blocked = false)
		{
		}
	}

	[SerializeField]
	private ActorTransform actorTransform;

	private static uint instanceIdCounter;

	private static List<SignatureAbility> abilityInstances;

	private static Dictionary<int, SignatureAbility> abilityInstancesByInstanceId;

	private static Dictionary<int, CharacterAbility> characterAbilityInstancesByInstanceId;

	private static Dictionary<int, PrestigeAbility> prestigeAbilityInstancesByInstanceId;

	private ActorRenderer actorRenderer;

	private SlotValueHolder svh;

	private AnimationStatus animationStatus;

	private Character character;

	private CharacterStats stats;

	private ActorData actorData;

	private int projectileType;

	private ActorState currentState;

	private Fixed3 queuedPositionChangeForFrame;

	private Fixed2 previousParentPosition;

	private bool extentOn;

	private int attachedBarrier;

	private AnimationHintType animationHintOverride;

	private uint instanceId;

	private Actor thrownBy;

	private Actor throwVictim;

	private bool hasEnded;

	private bool isDead;

	private bool allowMovement;

	private Fixed scaleMultiplier;

	private byte superFlashActiveMask;

	private byte frozenBySuperFlashMask;

	private Element element;

	private List<Modifier> modifiers;

	private Dictionary<ModifierType, List<Modifier>> modifierMap;

	private Modifier lastAppliedModifier;

	private bool ignoreDefense;

	private bool isUnflinching;

	private bool hasTagInDisabled;

	private bool hasSpecialDisabled;

	private bool hasSuperbarDisabled;

	private int sfxChannel;

	private bool frameCanHit;

	private bool frameMadeContact;

	private bool frameAlreadyWhiffed;

	private Fixed damageCapPercent;

	private HitInfo currentHitInfo;

	private SlotOpChain lastHitSlotOps;

	private SlotOpChain lastHitBlockSlotOps;

	private ActorData paletteEffectActorDataToUse;

	private ActorData paletteEffectActorDataLastAttacker;

	private List<GearStatusTracker> gearTrackers;

	private int queuedMoveIndex;

	private int activeMoveIndex;

	private bool forceUseQueuedMove;

	private int delayedUseMoveIndex;

	private List<Actor> children;

	private ushort paletteEffectCycleCount;

	private float paletteEffectSelf2CycleCount;

	private SignatureAbility signatureAbilityInstance;

	private SignatureAbility superAbilityInstance;

	private CharacterAbility characterAbilityInstance;

	private PrestigeAbility prestigeAbilityInstance;

	private bool hasBeenTouched;

	private bool hasBlocked;

	private bool isAttacking;

	private bool blockingAllowed;

	private int comboHitCount;

	private int resetComboTimer;

	private int comboCounterResetFrameDelay;

	private bool isGetHitPause;

	private int hitPauseVibrationCount;

	private int totalHitPause;

	private Fixed floorHeight;

	private uint lastAniEvent;

	private Fixed lastLifebar;

	private Fixed fractionalLifebarAdjustment;

	private Fixed fractionalRedLifeAdjustment;

	private Fixed guardMeter;

	private int guardMeterLockoutFrames;

	public int throwInvincibleTimer;

	private const int kTimeBetweenThrowInvincibleFlashes = 6;

	private int throwInvincibleFlashTimer;

	private static Fixed[] tempSlots;

	private int lastSeenFrontEndFrameForShinyEffect;

	private RingBuffer<ZInput> motionInputBuffer;

	private bool[] motionsEntered;

	private int motionsEnteredEffectiveSize;

	private uint performingMoveTag;

	private uint delayedMoveTag;

	private static bool doNotActOnNewInputs;

	private static readonly Fixed kP2AirborneCollisionPercent;

	private static readonly Fixed kP1AirborneCollisionPercent;

	private static CollisionData[] previousCollisionData;

	private static CollisionData[] currentCollisionData;

	private static FixedBounds[] startCollisionBounds;

	private static FixedBounds[] endCollisionBounds;

	private static Fixed3[] collisionVelocity;

	private static Fixed3[] collisionNewPos;

	private static FixedBounds[] collisionTempBoxes;

	private static Fixed[] collisionMovementAmounts;

	private CollisionData savedCollisionData;

	private const int indexL = 0;

	private const int indexR = 1;

	private bool lastHitWasCrit;

	private static readonly uint ARMOR_HASH;

	public Transform cachedTransform => null;

	private void Awake()
	{
	}

	public static void ClearAllAbilityInstances(bool reserveHitsparkId)
	{
	}

	public static List<SignatureAbility> GetAbilityInstances()
	{
		return null;
	}

	public static List<PrestigeAbility> GetPrestigeAbilityInstances()
	{
		return null;
	}

	public static void AddAbilityInstance(SignatureAbility signatureAbility)
	{
	}

	public static SignatureAbility GetAbilityInstance(int instanceId)
	{
		return null;
	}

	public static PrestigeAbility GetPrestigeAbilityInstance(int instanceId)
	{
		return null;
	}

	public static int GetLifebarPercent(float life, float maxLife)
	{
		return 0;
	}

	public void Init(Character myCharacter)
	{
	}

	public void Init(ActorData data)
	{
	}

	public void InitializeTeamInfo(int positionInTeam, int playerNumber)
	{
	}

	public void End()
	{
	}

	public bool HasEnded()
	{
		return false;
	}

	public void Step(bool updateVisuals = true)
	{
	}

	public void Prewarm(int frames)
	{
	}

	public bool IsPrewarm()
	{
		return false;
	}

	public static void SetDoNotActOnNewInputs(bool doNotAct)
	{
	}

	public void CheckMotions(ZInput newInput = null)
	{
	}

	public void SubmitToRender()
	{
	}

	public Bounds GetRenderBounds()
	{
		return default(Bounds);
	}

	public void ApplyPositionChanges()
	{
	}

	public Vector3 GetVector3Position()
	{
		return default(Vector3);
	}

	public Fixed3 GetPosition()
	{
		return default(Fixed3);
	}

	public Vector3 GetVector3LocalScale()
	{
		return default(Vector3);
	}

	public Fixed GetArtRotAngle()
	{
		return default(Fixed);
	}

	public Fixed3 GetLocalScale()
	{
		return default(Fixed3);
	}

	public bool IsLocalPlayerP1()
	{
		return false;
	}

	public void ImmediateSetPosition(Vector3 value)
	{
	}

	public void ImmediateSetPosition(Fixed3 value)
	{
	}

	public void QueuePositionChange(Fixed3 positionChange)
	{
	}

	public void QueuePositionSet(Fixed3 position)
	{
	}

	public Fixed3 GetPositionForCamera(bool forSuperflash = false)
	{
		return default(Fixed3);
	}

	public Fixed3 GetVisiblePixelPos(Actor actor)
	{
		return default(Fixed3);
	}

	public Fixed3 GetVisiblePixelPos(Actor actor, Fixed topPctRequired)
	{
		return default(Fixed3);
	}

	public void UpdateTetheredPosition()
	{
	}

	public void StartSpecialCooldowns(float cooldownOverride = 0f, bool skipOneTimeUseMoves = false)
	{
	}

	public void ResetSpecialCooldowns()
	{
	}

	public GearStatusTracker GetActiveGearTracker()
	{
		return null;
	}

	public void SetActiveGearTracker(int index)
	{
	}

	public GearStatusTracker GetQueuedGearTracker()
	{
		return null;
	}

	public void ClearQueuedGearTracker()
	{
	}

	public void ForceUseQueuedGear()
	{
	}

	public GearStatusTracker GetGearTrackerAt(int idx)
	{
		return null;
	}

	public List<GearStatusTracker> GetGearTrackers()
	{
		return null;
	}

	public int GetUpdatePriority()
	{
		return 0;
	}

	public int GetPlayerNumber()
	{
		return 0;
	}

	public Character GetCharacter()
	{
		return null;
	}

	public CharacterStats GetStats()
	{
		return null;
	}

	public Element GetElement()
	{
		return default(Element);
	}

	public void SetElement(Element element)
	{
	}

	public TeamType GetTeamType()
	{
		return default(TeamType);
	}

	public Team GetTeam()
	{
		return null;
	}

	public int GetLeaderInTeamIndex()
	{
		return 0;
	}

	public bool IsOnGround()
	{
		return false;
	}

	public bool IsPointCharacter()
	{
		return false;
	}

	public void SetAllowMovement(bool allow)
	{
	}

	public void SetScaleMultiplier(Fixed multiplier)
	{
	}

	public int GetLife()
	{
		return 0;
	}

	public int GetRedLife()
	{
		return 0;
	}

	public int GetMaxLife()
	{
		return 0;
	}

	public Fixed GetGuardMeter()
	{
		return default(Fixed);
	}

	public int GetAttack()
	{
		return 0;
	}

	public bool IsDead()
	{
		return false;
	}

	public void SetDead()
	{
	}

	public bool IsInHitstun()
	{
		return false;
	}

	public bool IsInBlockstun()
	{
		return false;
	}

	public SlotValueHolder GetSVH()
	{
		return null;
	}

	public bool HasLastHitSlotOps()
	{
		return false;
	}

	public bool ClearLastHitSlotOps()
	{
		return false;
	}

	public bool IsCharacterAbilityUnlocked()
	{
		return false;
	}

	public void SetIsUnflinching(bool unflinching)
	{
	}

	public bool IsUnflinching()
	{
		return false;
	}

	public bool IsAttackUnblockable()
	{
		return false;
	}

	public bool AttemptAutoBlockActivation()
	{
		return false;
	}

	public void SetIgnoreDefense(bool ignore)
	{
	}

	public bool GetIgnoreDefense()
	{
		return false;
	}

	public bool IsInvincible()
	{
		return false;
	}

	public void SetDamageCapPercent(Fixed percent)
	{
	}

	public void ResetDamageCapPercent()
	{
	}

	public float GetCappedDamage(float damage)
	{
		return 0f;
	}

	public float GetDamageTakenLastHit()
	{
		return 0f;
	}

	public float CalculateAttackDamage(float hitInfoDamage, Actor attackee)
	{
		return 0f;
	}

	public float CalculateScaledAttackDamage(float hitInfoDamage, Actor attackee)
	{
		return 0f;
	}

	public void AddToCombo(int amount, bool applyDamageScaling = true)
	{
	}

	public void ResetCombo()
	{
	}

	public void ResetUsedGearThisCombo()
	{
	}

	public int GetComboHitCount()
	{
		return 0;
	}

	public void SetFacingDirection(FacingDirection direction)
	{
	}

	public bool IsFacingRight()
	{
		return false;
	}

	public byte GetSuperFlashActiveMask()
	{
		return 0;
	}

	public bool IsFrozenByAnySuperFlash()
	{
		return false;
	}

	public bool ShouldSkipSuperflash()
	{
		return false;
	}

	public void SetFrozenBySuperFlashMask(byte mask, bool enableThese)
	{
	}

	public int GetCurrentPaletteNumber()
	{
		return 0;
	}

	public byte GetPaletteEntryValue(int colorNum, int whichColor)
	{
		return 0;
	}

	public bool GetThisFrameCanHit()
	{
		return false;
	}

	public bool GetThisFrameHasHitbox()
	{
		return false;
	}

	public void FlushInputBuffer()
	{
	}

	public bool DidPerformDashAttackOrDashBackThisFrame()
	{
		return false;
	}

	public void SetHitPause(int hitpause)
	{
	}

	public float GetVisualHitPauseXVibration()
	{
		return 0f;
	}

	public int GetPaletteFXCycleCount(int whichOne)
	{
		return 0;
	}

	public HitInfo GetCurrentHitInfo()
	{
		return null;
	}

	public bool CurrentStateHasTag(uint tag)
	{
		return false;
	}

	public bool CurrentStateHasTag(string tag)
	{
		return false;
	}

	public void GetThrownBy(Actor thrower)
	{
	}

	public void GetUnthrownBy(Actor thrower)
	{
	}

	public void SetThrowVarsOnVictim(bool setPositionAndFrame)
	{
	}

	public Actor GetThrowVictim()
	{
		return null;
	}

	public Actor GetThrower()
	{
		return null;
	}

	public Vector2 GetThrowPointOffset(uint pointNameHash)
	{
		return default(Vector2);
	}

	public void AddLightsToWorld(World world)
	{
	}

	public ActorData GetActorData()
	{
		return null;
	}

	public ActorRenderer GetRenderer()
	{
		return null;
	}

	public ActorData GetPaletteFXActorDataToUse()
	{
		return null;
	}

	public void SetPaletteFXActorDataToUse(ActorData data)
	{
	}

	public void SetLastAttackerPaletteFXInfo(Actor actor)
	{
	}

	public ActorData GetPaletteFXActorDataLastAttacker()
	{
		return null;
	}

	public void SetPaletteFXActorDataLASTATTACKER(ActorData data)
	{
	}

	public AniFrame GetCurrentAniFrame()
	{
		return null;
	}

	public AniFrameHolder GetCurrentFrameHolder()
	{
		return null;
	}

	public ActorState GetCurrentState()
	{
		return null;
	}

	public bool IsFirstFrameOfState()
	{
		return false;
	}

	public void AddModifier(Modifier modifier)
	{
	}

	public bool RemoveModifier(Modifier modifier, bool removePermanent = false)
	{
		return false;
	}

	public void RemoveAllModifiersOfType(ModifierType modifierType, bool removePermanent = false)
	{
	}

	public int RemoveModifierType(ModifierType modifierType, ModifierStrength modifierStrength = ModifierStrength.Normal, bool removePermanent = false, bool allStrengths = false)
	{
		return 0;
	}

	public void RemoveModifierNotType(ModifierType modifierType, ModifierStrength modifierStrength = ModifierStrength.Normal, bool removePermanent = false, bool allStrengths = false)
	{
	}

	public void ClearModifiers(bool removePermanent = false)
	{
	}

	public void SetLastAppliedModifier(Modifier modifier)
	{
	}

	public Modifier GetLastAppliedModifier()
	{
		return null;
	}

	public List<Modifier> GetModifiers()
	{
		return null;
	}

	public Modifier GetModifierOfType(ModifierType type)
	{
		return null;
	}

	public bool HasModifierOfType(ModifierType type)
	{
		return false;
	}

	public int GetModifierTypeCount(ModifierType type)
	{
		return 0;
	}

	public bool HasModifierOfClass(Type type, bool isTypeNone)
	{
		return false;
	}

	public void SetAnimationHintOverride(AnimationHintType hintOverride)
	{
	}

	public float GetMaxSuperbar()
	{
		return 0f;
	}

	public float GetLargestBlockbusterSuperbarPercent()
	{
		return 0f;
	}

	public void SetFloorHeight(float newFloorHeight)
	{
	}

	public float GetFloorHeight()
	{
		return 0f;
	}

	public void SetSfxChannel(int channel)
	{
	}

	public void TakeDamage(float damage, bool showDamageText = true, bool canKill = true, DamageType damageType = DamageType.NORMAL, bool shouldTakeBarrierDamage = true)
	{
	}

	public void TakeBarrierDamage(ref float damage, ref DamageType damageType)
	{
	}

	public void AddToFractionalLifebarAdjustment(Fixed adjustment)
	{
	}

	public Fixed GetFractionalLifebarAdjustment()
	{
		return default(Fixed);
	}

	public void AddToFractionalRedLifeAdjustment(Fixed adjustment)
	{
	}

	public Fixed GetFractionalRedLifeAdjustment()
	{
		return default(Fixed);
	}

	public Fixed GetLastLifebar()
	{
		return default(Fixed);
	}

	public uint GetLastAniEvent()
	{
		return 0u;
	}

	public bool HasTagInDisabled()
	{
		return false;
	}

	public void SetHasTagInDisabled(bool disabled)
	{
	}

	public bool HasSpecialDisabled()
	{
		return false;
	}

	public void SetHasSpecialDisabled(bool frozen)
	{
	}

	public bool HasSuperbarDisabled()
	{
		return false;
	}

	public void SetHasSuperarDisabled(bool disabled)
	{
	}

	public bool HasHealBlocked()
	{
		return false;
	}

	public bool HasInversePolarity()
	{
		return false;
	}

	public float GetLastHitBarrierDamage()
	{
		return 0f;
	}

	public void AddChild(Actor child)
	{
	}

	public void AddChildren(List<Actor> children)
	{
	}

	public void RemoveChild(Actor child)
	{
	}

	public List<Actor> GetChildren()
	{
		return null;
	}

	public void SetAllChildrenEnemySVH(SlotValueHolder enemy)
	{
	}

	public CharacterAbility GetCharacterAbilityInstance()
	{
		return null;
	}

	public SignatureAbility GetSignatureAbilityInstance()
	{
		return null;
	}

	public PrestigeAbility GetPrestigeAbilityInstance()
	{
		return null;
	}

	public bool HasPrestigeAbilityActivated()
	{
		return false;
	}

	public bool IsInputReceivingChild()
	{
		return false;
	}

	public uint GetActorInstanceId()
	{
		return 0u;
	}

	public bool IsProjectile()
	{
		return false;
	}

	public bool IsHitspark()
	{
		return false;
	}

	public bool IsFighter()
	{
		return false;
	}

	public static void SaveStateStatic(BinaryWriter writer)
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void SaveStatePart2(BinaryWriter writer)
	{
	}

	public static void LoadStateStatic(BinaryReader reader)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	public void LoadStatePart2(BinaryReader reader)
	{
	}

	public void SavePseudoState(BinaryWriter writer)
	{
	}

	public bool IsPlayingVO()
	{
		return false;
	}

	public void ResetOncePerComboFlags()
	{
	}

	private void EnqueueInput(ZInput input)
	{
	}

	private void InternalAdvance()
	{
	}

	private void MoveForCurrentFrame()
	{
	}

	private void SetCurrentState(ActorState newState)
	{
	}

	private void RestartAnimAndResetSlots(ActorState previousState)
	{
	}

	private void ApplyArithmeticSlotOps(SlotOpChain slotOpsToApply)
	{
	}

	private void PutExtraInfoInSlots()
	{
	}

	private void HandleSoundEvent(uint soundEventHash)
	{
	}

	private void PlaySoundEffect(SoundEffect sfx, List<AudioClip> sfxList)
	{
	}

	public static void HandleSoundEvents(Actor actor, ActorData verifyActorData, uint meEvent, uint parentEvent, uint enemyEvent, uint pointEvent, uint childEvent)
	{
	}

	private void ApplyQueuedPositionChangesWithCollision(Fixed3 positionChange)
	{
	}

	private void CreateProjectiles(ProjectileInfo projectileInfo)
	{
	}

	private void CreateProjectileByType(ushort type, Fixed3 spawnPosition, bool spawnPositionInLocalSpace, SlotOpChain initSlotOps, Actor overrideAttacker = null)
	{
	}

	private void ApplyElementalDamage(Actor other, ref DamageType damageType, ref float damage)
	{
	}

	private void PerformActionForChildrenThatReceiveInput(Action<Actor> callback)
	{
	}

	private void AddToModifierMap(Modifier modifier)
	{
	}

	private void RemoveFromModifierMap(Modifier modifier)
	{
	}

	private void UpdateThrowInvincibilityFlashing()
	{
	}

	private void UpdateGuardMeter()
	{
	}

	private void LogStateError(string message)
	{
	}

	public static bool CheckCollision(Actor playerActor, Actor enemyActor)
	{
		return false;
	}

	public static Fixed GetDistanceBetweenActors(Actor actor1, Actor actor2)
	{
		return default(Fixed);
	}

	public static void ApplyEvadeHitpause(Actor evadingActor, Actor attackingActor)
	{
	}

	public void UpdateCollisionCheckInfo()
	{
	}

	public bool HasHit(Actor other, ref Fixed3 hitPos, ref int hitsparkType, ref uint sparkSoundSlotValue, ref bool wasInvincibleToHit, HitCheckType whatHitTypesAreOK)
	{
		return false;
	}

	public FixedBounds GetDefaultBounds()
	{
		return default(FixedBounds);
	}

	public FixedBounds GetDefaultBoundsPositioned(Fixed3 position)
	{
		return default(FixedBounds);
	}

	public FixedBounds GetBounds(bool fallbackIfZero = false)
	{
		return default(FixedBounds);
	}

	public void DoFakeHit()
	{
	}

	public bool GetLastHitWasCrit()
	{
		return false;
	}

	public bool GetAttackerCurrentHitCannotKill()
	{
		return false;
	}

	public void SetLastHitWasCrit(bool wasCrit)
	{
	}

	public void DrawHitBoxes(BoxType type)
	{
	}

	public int GetNumBoxes(BoxType type)
	{
		return 0;
	}

	private bool CanInteractWith(Actor other)
	{
		return false;
	}

	private FixedBounds GetNthBox(BoxType type, int n)
	{
		return default(FixedBounds);
	}

	private FixedBounds PositionAndScaleBox(FixedBounds box, Fixed3 position)
	{
		return default(FixedBounds);
	}

	private int GetNumberOfChargeAttackHits()
	{
		return 0;
	}
}
