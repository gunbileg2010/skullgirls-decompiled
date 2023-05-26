using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CharacterAbilityMsFortune : CharacterAbility
{
	[SerializeField]
	private PalettizedImage msFortuneImage;

	[SerializeField]
	private PalettizedImage recallImage;

	[SerializeField]
	private PalettizedImage felineAllergiesImage;

	[SerializeField]
	private PalettizedImage headbuttImage;

	[SerializeField]
	private PalettizedImage zoomImage;

	[SerializeField]
	private Sprite backingFrameSprite;

	private List<CharacterAbilityButton> auxButtons;

	private bool headlessActive;

	private Actor myHead;

	private static readonly uint headOffTag;

	private static readonly uint recallTag;

	private static readonly uint headButtAttackTag;

	private static readonly uint zoomAttackTag;

	private static readonly uint sneezeAttackTag;

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

	public override uint GetStickyInputClearTag(int buttonId = 0)
	{
		return 0u;
	}

	public override void OnButtonUp(int buttonId = 0)
	{
	}

	public override PalettizedImage GetPalettizedImage(int buttonId)
	{
		return null;
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

	private void ToggleHeadless(bool isActive)
	{
	}

	private void UpdateHeadlessUI(bool isActive, bool immediate = false)
	{
	}

	private uint GetTagForButtonId(int buttonId)
	{
		return 0u;
	}
}
