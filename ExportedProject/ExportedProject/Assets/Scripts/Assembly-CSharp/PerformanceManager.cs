using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceManager : MonoBehaviour
{
	public enum DeviceTier : byte
	{
		Low = 0,
		Normal = 1
	}

	private const float kLowEndRAMInGB = 1.9f;

	private DeviceTier kDeviceTier;

	private List<Resolution> supportedResolutions;

	private bool wereSettingsAutoAdjusted;

	private float fpsDeltaTime;

	private float fpsUpdateTime;

	private float fpsSampleInterval;

	private List<float> fpsFightSamples;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public List<Resolution> GetSupportedResolutions()
	{
		return null;
	}

	public int GetCurrentResolutionIndex()
	{
		return 0;
	}

	public void SetResolution(int index)
	{
	}

	public void SetResolution(Resolution resolution)
	{
	}

	public Resolution GetLargestSupportedResolution()
	{
		return default(Resolution);
	}

	public void UpdateTargetFramerate()
	{
	}

	public void AutoAdjustSettingsBasedOnDeviceTier()
	{
	}

	public bool WereSettingsAutoAdjusted()
	{
		return false;
	}

	public float GetAndClearAverageFightFPS()
	{
		return 0f;
	}

	private void BuildSupportedResolutionsList()
	{
	}

	private Resolution GetPreferredResolution()
	{
		return default(Resolution);
	}

	private Resolution GetNearestSupportedResolution(int width, int height)
	{
		return default(Resolution);
	}

	private void DetectDeviceTier()
	{
	}

	private IEnumerator DoSetResolution(Resolution resolution)
	{
		return null;
	}

	private void UpdateFPSTracker()
	{
	}
}
