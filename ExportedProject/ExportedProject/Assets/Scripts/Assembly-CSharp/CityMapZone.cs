using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CityMapZone : MonoBehaviour
{
	[SerializeField]
	private Zone zone;

	[SerializeField]
	private Button zoneAreaButton;

	[SerializeField]
	private CityMapZonePlacard zonePlacard;

	[SerializeField]
	private string mapVisualKey;

	[SerializeField]
	private Image indicator;

	private ZoneState state;

	public event Action<CityMapZone, int> OnZoneClicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void HideUIElements()
	{
	}

	public void AddChapterIndexToZone(int chapterIndex, float completionPercent, bool isLocked, int? completedChallenges, int? totalChallenges)
	{
	}

	public void SetState(ZoneState zoneState, bool forceVisualRefresh = false)
	{
	}

	public void ShowIndicator()
	{
	}

	public void JumpToChapterIndex(int chapterIndex)
	{
	}

	public void DEBUG_UnlockAll()
	{
	}

	public ZoneState GetState()
	{
		return default(ZoneState);
	}

	public Zone GetZoneAsset()
	{
		return null;
	}

	public bool IsMultiChapter()
	{
		return false;
	}

	public void EnterChapter(int chapterIndex)
	{
	}

	public void UGUI_OnPressed()
	{
	}

	private void ResetToInactive()
	{
	}
}
