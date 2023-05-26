using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
	[SerializeField]
	private bool useServerTime;

	[SerializeField]
	private Text text;

	[SerializeField]
	private bool daysShortcut;

	[SerializeField]
	private Image[] digitImages;

	[SerializeField]
	private Image[] multidayImages;

	[SerializeField]
	private Image[] additionalImages;

	private Coroutine timerCoroutine;

	private DateTime? expirationDateTime;

	private Action expiredCallback;

	private int lastDays;

	private int lastHours;

	private int lastMinutes;

	private int lastSeconds;

	private bool showingGraphics;

	private float timerSecondsToColorChangeThreshold;

	private Color? timerChangeoverColor;

	private Color? originalColor;

	private bool changeTimerColor;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	public void Show(DateTime? expirationDateTime, Action expiredCallback = null, bool showingGraphics = true, float timerSecondsToColorChangeThreshold = 0f, Color? timerChangeoverColor = null)
	{
	}

	public void Hide()
	{
	}

	public void ClearExpirationCallback()
	{
	}

	public void SetValue(float secondsRemaining)
	{
	}

	public void SetColor(Color color)
	{
	}

	public bool IsTimerRunning()
	{
		return false;
	}

	private void StartTimer()
	{
	}

	private void StopTimer()
	{
	}

	private IEnumerator UpdateTimer(DateTime expirationDateTime, DateTime currentTime, Action timerCompleteCallback)
	{
		return null;
	}

	private void SyncToCurrentDateTime(DateTime serverTime)
	{
	}

	private Color? GetCurrentColor()
	{
		return null;
	}
}
