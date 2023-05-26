using UnityEngine;
using UnityEngine.UI;

public class GuardMeter : MonoBehaviour
{
	[SerializeField]
	private Image guardMeterImage;

	[SerializeField]
	private Image guardMeterFlashOverlay;

	[SerializeField]
	private float flashFadeRate;

	[SerializeField]
	private float guardCrushFlashingLength;

	[SerializeField]
	private Image[] frameImages;

	private Actor actor;

	private float guardCrushFlashingLengthRemaining;

	private float timeSinceLastFlashChange;

	[SerializeField]
	private float timeBetweenFlashChanges;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetActor(Actor newActor)
	{
	}

	public void DoGuardCrushFlash()
	{
	}

	public void DoGuardMeterDamagedFlash()
	{
	}

	private void RefreshGuardMeterValue()
	{
	}
}
