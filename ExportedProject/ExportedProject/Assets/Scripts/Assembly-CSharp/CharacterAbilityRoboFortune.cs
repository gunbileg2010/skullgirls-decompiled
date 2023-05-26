using System.Collections.Generic;
using UnityEngine;

public class CharacterAbilityRoboFortune : CharacterAbility
{
	[SerializeField]
	private PalettizedImage launchImage;

	[SerializeField]
	private PalettizedImage salvoImage;

	[SerializeField]
	private PalettizedImage ramImage;

	[SerializeField]
	private PalettizedImage mineImage;

	[SerializeField]
	private Sprite backingFrameSprite;

	[SerializeField]
	private ModifierIcon detonationIcon;

	private List<CharacterAbilityButton> auxButtons;

	private static readonly uint headSpawnTag;

	private static readonly uint salvoTag;

	private static readonly uint ramTag;

	private static readonly uint mineTag;

	private const int kDetonationModeFlag = 29;

	private const Slot kDetonationTimerSlot = Slot.USER_FIRST;

	private const int kDetonationModeStartingTimer = 700;

	private Actor detonationTimer;

	private static readonly uint timerTag;

	private void OnEnable()
	{
	}

	private void OnDisable()
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

	public override ButtonMode GetButtonMode(int buttonId = 0)
	{
		return default(ButtonMode);
	}

	public override uint GetStickyInputClearTag(int buttonId = 0)
	{
		return 0u;
	}

	public override PalettizedImage GetPalettizedImage(int buttonId)
	{
		return null;
	}

	public override void ResetCAButtonPostGameStateLoad()
	{
	}

	private void ShowHideDetModeIcon(bool show)
	{
	}

	private Actor GetDetonationTimerActor()
	{
		return null;
	}
}
