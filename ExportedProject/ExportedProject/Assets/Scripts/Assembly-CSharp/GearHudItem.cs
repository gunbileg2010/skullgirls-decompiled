using UnityEngine;
using UnityEngine.UI;

public class GearHudItem : MonoBehaviour
{
	[SerializeField]
	private GameObject queuedGO;

	[SerializeField]
	private AbstractEZSelfContainedAnimator availableAnim;

	[SerializeField]
	private GameObject activeEffectsGO;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Material grayscaleMaterial;

	[SerializeField]
	private GameObject specialFrameGO;

	[SerializeField]
	private Image specialFrameLeft;

	[SerializeField]
	private Image specialFrameRight;

	[SerializeField]
	private Sprite[] specialFrameSprites;

	[SerializeField]
	private PalettizedUIImage palettizedSMImage;

	[SerializeField]
	private GameObject[] specialFillGOs;

	[SerializeField]
	private PalettizedUIImage specialImageFill;

	[SerializeField]
	private Image specialFrameLeftFill;

	[SerializeField]
	private Image specialFrameRightFill;

	[SerializeField]
	private AnimationClip specialFillAnimClip;

	[SerializeField]
	private Image blockbusterFrame;

	[SerializeField]
	private Image blockbusterFrameFill;

	[SerializeField]
	private Sprite[] blockbusterFrameSprites;

	[SerializeField]
	private Material[] blockbusterFrameMaterials;

	[SerializeField]
	private PalettizedUIImage palettizedBBImage;

	[SerializeField]
	private GameObject[] blockbusterFillGOs;

	[SerializeField]
	private PalettizedUIImage blockbusterImageFill;

	[SerializeField]
	private AnimationClip blockbusterFillAnimClip;

	[SerializeField]
	private Image lockImage;

	private int playerNumber;

	private int inTeamIndex;

	private bool canUse;

	private ZInput relatedInput;

	private GearType gearType;

	private GearStatusTracker gearTracker;

	private void Update()
	{
	}

	public bool IsInteractable()
	{
		return false;
	}

	public void Populate(Actor actor, GearStatusTracker gearTracker)
	{
	}

	public void SetInteractiveAndBlocking(bool interactive)
	{
	}

	public void UGUI_UseItem()
	{
	}

	private void ActivateGraphicalItems()
	{
	}

	private void TransitionToCanUse(bool animate)
	{
	}

	private void TransitionToCantUse()
	{
	}
}
