using UnityEngine;
using UnityEngine.UI;

public class PrestigeMeter : MonoBehaviour
{
	[SerializeField]
	private GameObject queuedGO;

	[SerializeField]
	private GameObject fullMeterElements;

	[SerializeField]
	private GameObject activationEffects;

	[SerializeField]
	private GameObject readyMeterElements;

	[SerializeField]
	private CanvasGroup readyMeterCanvas;

	[SerializeField]
	private GameObject[] readyEffects;

	[SerializeField]
	private Image backgroundPortraitBloom;

	[SerializeField]
	private Image backgroundPortraitImage;

	[SerializeField]
	private Animation[] prestigeMeterAnim;

	private PrestigeAbility prestigeAbilityInstance;

	private bool prestigeWasActive;

	private EZAnimation readyAnimation;

	private int playerNumber;

	private float lastSeenFillAmount;

	private void Update()
	{
	}

	public void Init(PrestigeAbility prestigeAbility, int playerNumber)
	{
	}

	public void UpdateFillAmount()
	{
	}

	private void ToggleReadyEffects(bool active)
	{
	}

	private void StartReadyAnimation()
	{
	}
}
