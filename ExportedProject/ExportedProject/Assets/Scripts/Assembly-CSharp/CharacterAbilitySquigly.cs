using System.IO;
using UnityEngine;

public class CharacterAbilitySquigly : CharacterAbility
{
	public bool debug;

	[SerializeField]
	private PalettizedImage squiglyImage;

	[SerializeField]
	private int chargeTimeInFrames;

	[SerializeField]
	private ModifierIcon abilityIcon;

	public const int kDragonStanceFlag = 15;

	public const int kWhipStanceFlag = 16;

	public const int kButtonDownFlag = 17;

	private float chargeLevel;

	private const float kMaxCharge = 2f;

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

	public int GetChargeTimeInFrames()
	{
		return 0;
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

	protected override void OnMatchStarted(object passed)
	{
	}

	protected override void OnPointCharacterChanged(object passed)
	{
	}

	protected override void OnFightFrameUpdated(object passed)
	{
	}

	protected override void OnActorAboutToTagOut(object passed)
	{
	}

	protected override void OnActorAboutToDie(object passed)
	{
	}

	private void ClearAll()
	{
	}

	private void EndChargeMode()
	{
	}

	private void ShowHideChargeIcon(bool show)
	{
	}

	private float GetChargeLevel()
	{
		return 0f;
	}
}
