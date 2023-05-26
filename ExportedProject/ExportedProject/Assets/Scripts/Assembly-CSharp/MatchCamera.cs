using System.IO;
using UnityEngine;

public class MatchCamera : MonoSingleton<MatchCamera>
{
	[SerializeField]
	private Transform cameraDefaultMarker;

	[SerializeField]
	private Camera simulationCamera;

	[SerializeField]
	private Camera[] renderCameras;

	[SerializeField]
	private Camera actorCamera;

	[SerializeField]
	private Camera aboveAllUIActorsCamera;

	[SerializeField]
	private Camera primaryUICamera;

	[SerializeField]
	private Fixed minWidth169;

	[SerializeField]
	private Fixed minWidth43;

	[SerializeField]
	private Fixed maxWidth;

	[SerializeField]
	private Fixed maxWidthEdgeBuffer;

	[SerializeField]
	private Fixed bottomEdgeBuffer169;

	[SerializeField]
	private Fixed bottomEdgeBuffer43;

	[SerializeField]
	private Fixed topEdgeZoomedInValue;

	[SerializeField]
	private Fixed topEdgeZoomedOutValue;

	[SerializeField]
	private Fixed camMoveInterpolationFactor;

	[SerializeField]
	private Fixed camFocusWeightDelta;

	[SerializeField]
	private Fixed camZoomInterpolationFactor;

	[SerializeField]
	private bool lowerFighterDictatesYPosition;

	[SerializeField]
	private Fixed screenPercentHeightToFollow;

	[SerializeField]
	private bool rotateCameraAtStageEdges;

	[SerializeField]
	private Fixed rotateAtEdgesDegrees;

	[SerializeField]
	private Fixed rotateAtDistanceFromEdges;

	[SerializeField]
	private Fixed visualBoundsNudgeForRotateAtEdge;

	[SerializeField]
	private float wideAspectZoomOutFactor;

	private static readonly Fixed CAM_NO_TOP_EXTENT_SET;

	private static readonly Fixed MAX_VERTICAL_ZOOM_FACTOR_FOR_THROWS;

	private static readonly Fixed THROW_CAM_EXTRA_HEIGHT_PERCENT;

	private static readonly Fixed DEADZONE_WIDTH_PERCENT;

	private static readonly Fixed CAM_SUPERFLASH_ZOOM;

	private const int SUPERFLASH_IN_FRAMES = 8;

	private const int SUPERFLASH_OUT_FRAMES = 8;

	private static readonly Fixed SUPERFLASH_IN_DELTA_PER_FRAME;

	private static readonly Fixed SUPERFLASH_OUT_DELTA_PER_FRAME;

	private static readonly Fixed MIN_ASPECT;

	private static readonly Fixed MAX_ASPECT;

	private static readonly Fixed ASPECT_DELTA;

	private Fixed camFocusWeight;

	private Fixed camZoomFactor;

	private Fixed3 cameraZoomedBottomCenterPos;

	private Fixed3 cameraZoomedOutBottomCenterPos;

	private Fixed3 cameraSuperflashBottomCenterPos;

	private FixedBounds worldCameraBounds;

	private Fixed3 previousCamPosActor1;

	private Fixed3 previousCamPosActor2;

	private Fixed3 previousSuperFlashCamObjPos;

	private FixedBounds cameraViewBounds;

	private CameraShakeType maxCameraShakeRequested;

	private Fixed shakeElapsedFrames;

	private Fixed shakeCyclesPerSec;

	private Fixed shakeAmplitude;

	private Fixed shakeInvTotalFrames;

	private Actor superFlashActiveActor;

	private Fixed superFlashType;

	private Fixed superFlashTimerValue;

	private Fixed superFlashZoomTimerValue;

	private bool wantSuperFlashZoom;

	private Fixed minSuperFlashZoomAllowed;

	private Fixed superShadowTimer;

	private Fixed minWidth;

	private Fixed minZoom;

	private int camHalfWidthMax;

	private int camHalfWidthMin;

	private int camHeightMax;

	private int camHeightMin;

	private Fixed camExtraRectBottomBuffer;

	private const int kGachaCamCenterX = 0;

	private const int kGachaCamCenterY = 10;

	private const int kGachaCamWidth = 47;

	private const int kGachaCamHeight = 27;

	private EZAnimateFloat positionAnim;

	protected override void Awake()
	{
	}

	public static Fixed AspectRatioLerp(Fixed min4_3, Fixed max16_9, Camera camera = null)
	{
		return default(Fixed);
	}

	public static Fixed3 AspectRatioLerp(Fixed3 min4_3, Fixed3 max16_9, Camera camera = null)
	{
		return default(Fixed3);
	}

	public static Fixed GetAspectRatioFactor(Camera camera = null)
	{
		return default(Fixed);
	}

	public static Fixed GetAspectRatio(Camera camera = null)
	{
		return default(Fixed);
	}

	public static bool IsUltraWidescreen()
	{
		return false;
	}

	public void SetGachaOpenScreenWorldCameraBounds()
	{
	}

	public void UpdateCamera(bool immediate = false)
	{
	}

	public void UpdateSuperFlash(Actor superFlashFocusActor, Fixed superFlashType, bool wantSuperShadows)
	{
	}

	public Fixed GetSuperFlashTimer()
	{
		return default(Fixed);
	}

	public Fixed GetSuperFlashType()
	{
		return default(Fixed);
	}

	public Fixed GetSuperShadowTimer()
	{
		return default(Fixed);
	}

	public void RequestCameraShake(CameraShakeType shakeType)
	{
	}

	public FixedBounds GetCameraBounds()
	{
		return default(FixedBounds);
	}

	public FixedBounds GetDeterministicCameraViewBounds()
	{
		return default(FixedBounds);
	}

	public void LerpCameraPosition(Vector3 newWorldPosition, float duration)
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	public void RenderActorsAboveUI(bool value)
	{
	}

	public void AssignCameraToUICanvas(Canvas canvas)
	{
	}

	public void ResetToDefaultPosition()
	{
	}

	public float GetLargestBottomEdgeBufferFor1080p()
	{
		return 0f;
	}

	public float GetFOV()
	{
		return 0f;
	}

	public float GetNearClipPlane()
	{
		return 0f;
	}

	public float GetFarClipPlane()
	{
		return 0f;
	}

	private void RecalculateCameraVariables()
	{
	}

	private void UpdateCameraCenterBottomPosition(ref Fixed centerX, ref Fixed bottomY, int camHalfWidth, int camHeight, bool useDeadZone, Fixed3 actor1Pos, Fixed3 actor2Pos, Fixed topBoundsY, bool snap, Fixed2 stageSize)
	{
	}

	private void EnsureParentIsAtOrigin()
	{
	}

	private void SetCameraPositions(Vector3 newPosition)
	{
	}

	private void SetCameraRotations(Quaternion newRotation)
	{
	}

	private void LookAtRect(FixedBounds viewRect)
	{
	}

	private void UpdateCameraShake(bool immediate)
	{
	}

	private void SetCameraShake(CameraShakeType shakeType)
	{
	}

	private void SetCameraShake(Fixed lengthInSec, Fixed cyclesPerSec, Fixed amplitudeInPixels)
	{
	}

	private static Camera SelectCameraForAspectRatioMath(Camera overrideCamera)
	{
		return null;
	}

	public MatchCamera()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
