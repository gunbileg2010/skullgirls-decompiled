using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugDiagnosticsSection : MonoBehaviour
{
	[SerializeField]
	private Toggle fpsToggle;

	[SerializeField]
	private Text chatStatusText;

	[SerializeField]
	private Text resourceLabelPrototype;

	[SerializeField]
	private Text totalMonoHeapSize;

	[SerializeField]
	private Text usedMonoHeapSize;

	[SerializeField]
	private Text totalReservedMemory;

	[SerializeField]
	private Text usedReservedMemory;

	[SerializeField]
	private Text totalAllocatedMemory;

	[SerializeField]
	private Text physicalMemory;

	[SerializeField]
	private Text systemMemory;

	[SerializeField]
	private Text textureCount;

	[SerializeField]
	private Text audioClipCount;

	[SerializeField]
	private Text meshCount;

	[SerializeField]
	private Text goCount;

	private DebugSettings debugSettings;

	private List<Text> resourceLabels;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void UGUI_ShowFpsToggle(bool isOn)
	{
	}

	public void UGUI_SnapshotMemoryUsage()
	{
	}

	public void UGUI_OutputTextures()
	{
	}

	public void UGUI_OutputAudioClips()
	{
	}

	public void UGUI_OutputMeshes()
	{
	}

	public void UGUI_OutputGameObjects()
	{
	}

	private int GetAssetCount<T>() where T : Object
	{
		return 0;
	}

	private void OutputAssetNames<T>() where T : Object
	{
	}

	private void SnapshotMemoryUsage()
	{
	}

	private void RefreshDynamicResources()
	{
	}
}
