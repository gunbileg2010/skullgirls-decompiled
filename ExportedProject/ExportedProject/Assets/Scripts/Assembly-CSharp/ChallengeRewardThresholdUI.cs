using System;
using System.Collections;
using UnityEngine;

public class ChallengeRewardThresholdUI : MonoBehaviour
{
	public enum ThresholdState
	{
		Unactivated = 0,
		Activated = 1,
		Claimed = 2
	}

	[SerializeField]
	private LocalizedUGUIText thresholdValueText;

	[SerializeField]
	private GameObject activatedGO;

	[SerializeField]
	private GameObject unactivatedGO;

	[SerializeField]
	private GameObject claimedGO;

	[SerializeField]
	private GameObject claimButtonGO;

	[SerializeField]
	private float wiggleAnimLength;

	[SerializeField]
	private float wiggleAmount;

	[SerializeField]
	private float delayBetweenWiggleSequences;

	[SerializeField]
	private float scaleAmount;

	[SerializeField]
	private int wiggleAnimCount;

	private ThresholdState thresholdState;

	private EZAnimation wiggleAnim;

	private EZAnimation scaleAnim;

	private Coroutine wiggleSequence;

	private int thresholdIndex;

	private int thresholdValue;

	private ContextualPopupItem rewardsTooltip;

	private Action<int> claimThresholdCallback;

	private Vector3 startRotation;

	private Vector3 destinationRotation;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void Populate(int thresholdIndex, int currentEgretPointCount)
	{
	}

	public void HideAnyToolTipsThatWereSpawned()
	{
	}

	public void UGUI_Pressed()
	{
	}

	public bool IsActivated()
	{
		return false;
	}

	public bool IsClaimed()
	{
		return false;
	}

	public int GetThresholdIndex()
	{
		return 0;
	}

	public int GetThresholdValue()
	{
		return 0;
	}

	public void SetClaimThresholdCallback(Action<int> callback)
	{
	}

	public void LaunchWiggleSequence()
	{
	}

	private void ShowTooltip()
	{
	}

	private void StopWiggleSequence()
	{
	}

	private void StopWiggleAnimations()
	{
	}

	private IEnumerator DoWiggleSequence()
	{
		return null;
	}
}
