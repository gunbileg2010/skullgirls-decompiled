using System.IO;
using UnityEngine;

public class CharacterAbilityBeowulf : CharacterAbility
{
	[SerializeField]
	private PalettizedImage beowulfImage;

	[SerializeField]
	private float hypeTime;

	[SerializeField]
	private ModifierIcon hypeIcon;

	[SerializeField]
	private int secondsUntilFreeHypeLevel;

	public const int kHypeFlag = 24;

	private int timer;

	private int hypeTimeFrames;

	private bool hypeReady;

	private bool hypeFull;

	private int hypeLevel;

	private const int kMaxHype = 3;

	public const Slot kHypeLevelSlot = Slot.LIGHT_G;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override ButtonMode GetButtonMode(int buttonId = 0)
	{
		return default(ButtonMode);
	}

	public override void OnButtonUp(int buttonId = 0)
	{
	}

	public override PalettizedImage GetPalettizedImage(int buttonId)
	{
		return null;
	}

	public override bool ShouldDisplayInPauseScreen()
	{
		return false;
	}

	public override string GetPauseScreenDescription()
	{
		return null;
	}

	public bool IsAtFullHype()
	{
		return false;
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

	public override void ResetCAButtonPostGameStateLoad()
	{
	}

	protected override void OnFightFrameUpdated(object passed)
	{
	}

	protected override void OnFightTimerTicked(object passed)
	{
	}

	protected override void OnActorAboutToTagOut(object passed)
	{
	}

	protected override void OnPointCharacterChanged(object passed)
	{
	}

	private void ClearAll()
	{
	}

	private void SetHypeReady(bool ready)
	{
	}

	private void StartTimer()
	{
	}

	private void EndHypeMode()
	{
	}

	private void ShowHideHypeIcon(bool show)
	{
	}
}
