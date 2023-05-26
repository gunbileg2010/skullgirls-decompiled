using HVS;
using UnityEngine;
using UnityEngine.UI;

public class DebugScreen : MonoSingleton<DebugScreen>
{
	[SerializeField]
	private GameObject debugWindowGO;

	[SerializeField]
	private float holdTime;

	[SerializeField]
	private Slider holdVisualizeSlider;

	[SerializeField]
	private int tapCount;

	[SerializeField]
	private Toggle defaultToggle;

	[SerializeField]
	private Toggle fightToggle;

	[SerializeField]
	private Toggle logToggle;

	[SerializeField]
	private GameObject fpsGO;

	[SerializeField]
	private GameObject offlineLabelGO;

	[SerializeField]
	private GameObject messageGO;

	[SerializeField]
	private GameObject slotDebugGO;

	private DebugSettings debugSettings;

	private int tapCounter;

	private float tapCounterResetTimer;

	private int pointerId;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void ToggleWindow()
	{
	}

	public void OpenWindow(bool forceToLog = false)
	{
	}

	public void CloseWindow()
	{
	}

	public void RefreshOnlineStatus()
	{
	}

	private void OnTouchInput(TouchInfo touchInfo)
	{
	}

	private void OnTap(TouchInfo tap)
	{
	}

	public DebugScreen()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
