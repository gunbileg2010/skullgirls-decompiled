using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignalBarUI : MonoBehaviour
{
	[Serializable]
	public struct SignalStrengthThreshold
	{
		public int filledBars;

		public Color filledBarColor;

		public float percentageThreshold;
	}

	[SerializeField]
	private Image[] barImages;

	[ReorderableList]
	[SerializeField]
	private List<SignalStrengthThreshold> signalStrengthThresholds;

	[SerializeField]
	private Color unfilledColor;

	[SerializeField]
	private float initialDisplayPercent;

	private float lastDisplayedPercent;

	private void Awake()
	{
	}

	public void SetDisplayPercentage(float percent)
	{
	}

	private void RefreshVisuals(SignalStrengthThreshold selectedSignalStrength)
	{
	}
}
