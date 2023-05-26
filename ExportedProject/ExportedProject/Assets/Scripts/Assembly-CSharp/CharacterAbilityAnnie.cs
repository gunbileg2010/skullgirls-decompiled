using UnityEngine;

public class CharacterAbilityAnnie : CharacterAbility
{
	public bool debug;

	[SerializeField]
	private PalettizedImage annieImage;

	[SerializeField]
	private Fixed chargeSpeedSeconds;

	[SerializeField]
	private Fixed chargeSpeedReadyMultiplier;

	[SerializeField]
	private Fixed drainSpeedSeconds;

	[SerializeField]
	private Fixed starPowerSpendStars;

	[SerializeField]
	private Fixed starPowerSpendSpecial;

	[SerializeField]
	private Fixed starPowerSpendToggleOn;

	[SerializeField]
	private Fixed starPowerSpendAnimationActivation;

	[SerializeField]
	private ModifierIcon hudIcon;

	[SerializeField]
	private float fillRotationSpeedInactive;

	[SerializeField]
	private float fillRotationSpeedActive;

	[SerializeField]
	private float rainbowLineArtSpeed;

	[SerializeField]
	private float rainbowLineArtBrightness;

	public const Slot kStarPowerActiveSlot = Slot.LIGHT_R;

	public const Slot kStarPowerChargePercentSlot = Slot.LIGHT_G;

	public const Slot kStarPowerChargeRateSlot = Slot.LIGHT_B;

	public const int kStarPowerNoDrainFlag = 31;

	public const int kStarPowerOncePerComboFlag = 70;

	public static readonly Fixed kMinChargePercentRequiredForActivation;

	private Fixed drainRate;

	private Actor starPowerManager;

	private readonly uint kStickyClearTag;

	private readonly uint kStarPowerSpecialTag;

	private readonly uint kStarPowerStarsTag;

	private readonly uint kStarPowerActivateAnimationTag;

	private readonly uint kStarPowerToggleOnTag;

	private void Awake()
	{
	}

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

	public override ButtonMode GetButtonMode(int index = 0)
	{
		return default(ButtonMode);
	}

	private void SetButtonMode()
	{
	}

	protected override void OnAniEvent(object passed)
	{
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

	private bool IsStarPowerActive()
	{
		return false;
	}

	public override string GetPauseScreenDescription()
	{
		return null;
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

	public override uint GetStickyInputClearTag(int buttonId = 0)
	{
		return 0u;
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

	private void ShowHideStarPowerIcon(bool show)
	{
	}

	private bool IsStarPowerActivationCancelValid()
	{
		return false;
	}

	private void TurnOffSuperShadows()
	{
	}
}
