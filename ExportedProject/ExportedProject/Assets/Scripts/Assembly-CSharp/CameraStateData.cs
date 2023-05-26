public struct CameraStateData
{
	public Fixed camFocusWeight;

	public Fixed camZoomFactor;

	public Fixed3 cameraZoomedBottomCenterPos;

	public Fixed3 cameraZoomedOutBottomCenterPos;

	public Fixed3 cameraSuperflashBottomCenterPos;

	public FixedBounds worldCameraBounds;

	public Fixed3 previousCamPosActor1;

	public Fixed3 previousCamPosActor2;

	public Fixed3 previousSuperFlashCamObjPos;

	public FixedBounds cameraViewRect;

	public byte maxCameraShakeRequested;

	public Fixed shakeElapsedFrames;

	public Fixed shakeCyclesPerSec;

	public Fixed shakeAmplitude;

	public Fixed shakeInvTotalTime;

	public uint superFlashActiveActorId;

	public Fixed superFlashType;

	public Fixed superFlashTimerValue;

	public Fixed superFlashZoomTimerValue;

	public bool wantSuperFlashZoom;

	public Fixed minSuperFlashZoomAllowed;

	public Fixed superShadowTimer;
}
