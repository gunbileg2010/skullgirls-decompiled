using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicAdButton : MonoBehaviour
{
	[SerializeField]
	private TimerUI adButtonTimer;

	[SerializeField]
	private GameObject adButtonOffState;

	[SerializeField]
	private GameObject tvFlickerObject;

	[SerializeField]
	private RewardItem potentialReward;

	[SerializeField]
	private CanvasGroup potentialRewardCanvasGroup;

	[SerializeField]
	private float fadeTime;

	[SerializeField]
	private float displayTime;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateAdButton(DateTime adPacingExpiration)
	{
	}

	private void OnLogin(AuthenticateRequest authenticateRequest)
	{
	}

	private IEnumerator CycleRewardsRoutine(List<Loot> lootToCycle)
	{
		return null;
	}
}
