using System.IO;
using UnityEngine;

public class CharacterAbilityUmbrella : CharacterAbility
{
	public enum HungernState
	{
		Ravenous = 2,
		Satiated = 3,
		Overstuffed = 4
	}

	public bool debug;

	[SerializeField]
	private PalettizedImage ravenousImage;

	[SerializeField]
	private PalettizedImage satiatedImage;

	[SerializeField]
	private PalettizedImage overstuffedImage;

	[SerializeField]
	private string ravenousText;

	[SerializeField]
	private string overstuffedText;

	[SerializeField]
	private Color ravenousColor;

	[SerializeField]
	private Color satiatedColor;

	[SerializeField]
	private Color overstuffedColor;

	[SerializeField]
	private Color ravenousGlowColor;

	[SerializeField]
	private Color satiatedGlowColor;

	[SerializeField]
	private Color overstuffedGlowColor;

	[SerializeField]
	private Sprite ravenousVFX;

	[SerializeField]
	private Sprite satiatedVFX;

	[SerializeField]
	private Sprite overstuffedVFX;

	public const Slot kHungernState = Slot.LIGHT_LOCAL_X;

	public const Slot kHungernCharge = Slot.LIGHT_Z;

	public static Fixed kMaxHungernCharge;

	private readonly uint kStickyClearTag;

	private int lastHungernState;

	private Fixed lastHungernCharge;

	private PalettizedImage currentImage;

	public override void Init(Actor actor)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
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

	public override string GetPauseScreenDescription()
	{
		return null;
	}

	public override void ResetCAButtonPostGameStateLoad()
	{
	}

	public Fixed GetLastHungernCharge()
	{
		return default(Fixed);
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

	private void UpdateCAButtonVisualsForHungernState(int hungernState)
	{
	}
}
