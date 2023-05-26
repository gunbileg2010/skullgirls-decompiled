using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterAbilityButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private int buttonId;

	[SerializeField]
	private PalettizedUIImage palettizedImage;

	[SerializeField]
	private Image frameImage;

	[SerializeField]
	private Image queueImage;

	[SerializeField]
	private Image backingImage;

	[SerializeField]
	private Color inactiveBackingColor;

	[SerializeField]
	private Color activeBackingColor;

	[SerializeField]
	private GameObject rainbowBackingGO;

	[SerializeField]
	private Image outerFrameImage;

	[SerializeField]
	private Image outerFrameFillWhite;

	[SerializeField]
	private Image outerFrameFillMask;

	[SerializeField]
	private GameObject outerFrameFillGO;

	[SerializeField]
	private GameObject extraNotchesGO;

	[SerializeField]
	private GameObject outerFrameBackgroundGO;

	[SerializeField]
	private GameObject staticRingGO;

	[SerializeField]
	private Image colorizedBackingImage;

	[SerializeField]
	private Image glowBackingImage;

	[SerializeField]
	private Image VFXBackingImage;

	[SerializeField]
	private Image dahliaBackingImage;

	[SerializeField]
	private GameObject ammoGO;

	[SerializeField]
	private GameObject chamberGO;

	[SerializeField]
	private Transform[] bulletChamberTransforms;

	[SerializeField]
	private CharacterAbilityButton dahliaReloadButton;

	[SerializeField]
	private Image[] bulletImages;

	[SerializeField]
	private Animation chamberAnimCA;

	private readonly Vector3 dahliaButtonFrameScale;

	private readonly Vector3 dahliaButtonFramePosition;

	private readonly Vector3 dahliaQueueImageScale;

	private readonly Vector3 dahliaQueueImagePosition;

	private Vector3 originalFrameImageScale;

	private Vector3 originalFrameImagePosition;

	private Vector3 originalQueueImageScale;

	private Vector3 originalQueueImagePosition;

	private readonly Vector3 kHiddenPosition;

	private readonly Vector3 kVisiblePosition;

	private RectTransform rectTransform;

	private EZAnimation showHideAnim;

	private CharacterAbility characterAbility;

	private CharacterAbility.ButtonMode buttonMode;

	private ZInput inputForButton;

	private TeamType teamType;

	private float outerFrameFillRotationSpeed;

	private const float rainbowBackingRotationSpeed = 20f;

	private bool doingChamberAnim;

	private Action chamberAnimEndCallback;

	private float ammoScaleOverride;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public int GetButtonId()
	{
		return 0;
	}

	public void SetInactiveAndGreyscale(bool value)
	{
	}

	public void SetOuterFrameFillRotationSpeed(float newValue)
	{
	}

	public void SetOuterFrameFillAmount(float newValue)
	{
	}

	public void SetAndFlashOuterFrameWhiteFill(float fillAmount)
	{
	}

	public void SetOuterFrameVisible(bool isOn, bool umbrellaOuterFrame = false)
	{
	}

	public void SetRainbowBackingVisible(bool isOn)
	{
	}

	public void SetPalettizedImageVisible(bool isOn)
	{
	}

	public void SetBackingColorToActive(bool active)
	{
	}

	public void SetColorizedBackingVisible(bool isOn)
	{
	}

	public void SetColorizedBacking(Color backingColor, Color glowColor, Sprite spriteVFX)
	{
	}

	public void SetFrameSprite(Sprite sprite)
	{
	}

	public void SetAmmoSprite(Sprite sprite, int ammoNum)
	{
	}

	public void HideAmmoSprite(int ammoNum)
	{
	}

	public void SetTeamType(TeamType overrideType)
	{
	}

	public void SetButtonMode(CharacterAbility.ButtonMode mode)
	{
	}

	public void Show(CharacterAbility ability, bool immediate = false, bool isDahliaButton = false)
	{
	}

	public void Hide(bool immediate = false, bool isDahliaButton = false)
	{
	}

	public void SetupReloadButton(CharacterAbility ability)
	{
	}

	public void ShowHideQueuedGlow(bool show)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void UGUI_ButtonPressed()
	{
	}

	public Button GetUGUIButton()
	{
		return null;
	}

	public void PlayChamberAnim(Action endCallback = null, float startTime = -1f)
	{
	}

	public float GetChamberAnimProgress()
	{
		return 0f;
	}

	public bool IsDoingChamberAnim()
	{
		return false;
	}

	public CharacterAbilityButton GetCharacterAbilityReloadButton()
	{
		return null;
	}

	private void SetImageFromCharacterAbility()
	{
	}

	private void ShowHideButton(bool show, bool immediate, bool dahliaButton = false)
	{
	}

	private void OnChamberUpdate()
	{
	}

	private void SetDahliaCAVisible(bool show)
	{
	}
}
