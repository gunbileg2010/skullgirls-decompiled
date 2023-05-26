using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToastManager : MonoBehaviour
{
	[Serializable]
	public class ToastData
	{
		public string titleLocKey;

		public string messageLocKey;

		public Sprite toastIcon;

		public bool showAchievementIcon;

		public DateTime scheduledTime;

		public DateTime expirationTime;

		public UnityAction callback;

		public ToastData(string titleLocKey, string messageLocKey, Sprite toastIcon)
		{
		}

		public ToastData(string titleLocKey, string messageLocKey, Sprite toastIcon, DateTime scheduledTime, DateTime expirationTime, UnityAction Callback)
		{
		}
	}

	[SerializeField]
	private CanvasBubbler canvasBubbler;

	[SerializeField]
	private float delayBetweenToasts;

	[SerializeField]
	private ToastNotification toastPrototype;

	[SerializeField]
	private int maxToasts;

	public const string kClaimNowLocKey = "ClaimNow";

	private List<ToastData> scheduledToasts;

	private Queue<ToastData> toastsToDisplay;

	private List<ToastNotification> displayingToasts;

	private List<ToastNotification> freeToasts;

	private float toastShowDelayTimer;

	private bool pauseToasts;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ScheduleToast(string titleLocKey, string messageLocKey, Sprite toastIcon, DateTime scheduledTime, DateTime expirationTime, UnityAction Callback = null)
	{
	}

	public void ShowToast(string titleLocKey, string messageLocKey, Sprite toastIcon)
	{
	}

	public void ShowToastForAchievement(string titleLocKey, string messageLocKey)
	{
	}

	public void PauseToasts(bool paused)
	{
	}

	private void TestShowToast()
	{
	}

	private void TestShowManyToasts()
	{
	}
}
