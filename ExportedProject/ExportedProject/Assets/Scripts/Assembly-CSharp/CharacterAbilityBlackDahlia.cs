using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CharacterAbilityBlackDahlia : CharacterAbility
{
	public bool debug;

	[SerializeField]
	private Sprite[] bulletSprites;

	public const Slot kAmmoSlot = Slot.LIGHT_R;

	public const Slot kAmmoCountSlot = Slot.LIGHT_B;

	public const int kMaxAmmoCount = 6;

	public static readonly uint gunShootEvent;

	public static readonly uint gunReloadStartedEvent;

	public static readonly uint gunReloadEvent;

	private readonly uint kStickyClearTagCA1;

	private readonly uint kStickyClearTagCA2;

	private readonly uint tagPreFire;

	private readonly uint bombArmed;

	private readonly uint bombExplode;

	private readonly uint tagInTag;

	private readonly int kBombGearId;

	private int lastAmmoValue;

	private int lastAmmoCount;

	private Fixed lastChamberTimeProgress;

	private Dictionary<Element, int> elementAmmoDict;

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Init(Actor actor)
	{
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public override ButtonMode GetButtonMode(int buttonId = 0)
	{
		return default(ButtonMode);
	}

	public override uint GetStickyInputClearTag(int buttonId = 0)
	{
		return 0u;
	}

	public override void ResetCAButtonPostGameStateLoad()
	{
	}

	protected override void OnMatchStarted(object passed)
	{
	}

	protected override void OnFightFrameUpdated(object passed)
	{
	}

	protected override void OnActorAboutToTagOut(object passed)
	{
	}

	protected override void OnPointCharacterChanged(object passed)
	{
	}

	protected override void OnAniEvent(object passed)
	{
	}

	private void SetCAButtonsVisible(bool isOn, bool immediate = false)
	{
	}

	private void OnAmmoUpdate(bool force = false)
	{
	}

	private void UpdateAmmoVisuals(int ammoValue, int ammoCount)
	{
	}

	private void OnGunShoot(float startTime = -1f)
	{
	}

	private void GetPreviousAmmoSlotValues(int currentAmmoValue, int currentAmmoCount, out int previousAmmoValue, out int previousAmmoCount)
	{
		previousAmmoValue = default(int);
		previousAmmoCount = default(int);
	}
}
