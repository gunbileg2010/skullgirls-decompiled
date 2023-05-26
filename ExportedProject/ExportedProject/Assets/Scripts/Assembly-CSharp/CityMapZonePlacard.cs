using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityMapZonePlacard : MonoBehaviour
{
	private struct ChapterData
	{
		public Zone sourceZone;

		public string chapterAreaNameLocKey;

		public int chapterIndex;

		public float completionPercent;

		public bool isLocked;

		public int? challengesCompleted;

		public int? totalChallenges;

		public ChapterData(Zone zone, string locKey, int index, float percent, bool locked, int? completedMC, int? totalMC)
		{
		}
	}

	[SerializeField]
	private LocalizedUGUIText nameText;

	[SerializeField]
	private LocalizedUGUIText completionText;

	[SerializeField]
	private GameObject lockedSymbol;

	[SerializeField]
	private RectTransform rectTransForSizeControl;

	[SerializeField]
	private GameObject matchChallengesParentGO;

	[SerializeField]
	private LocalizedUGUIText completedChallengesText;

	[SerializeField]
	private LocalizedUGUIText totalChallengesText;

	[SerializeField]
	private Button leftArrow;

	[SerializeField]
	private Button rightArrow;

	[SerializeField]
	private LocalizedUGUIText chapterText;

	[SerializeField]
	private float oneChapterRectTransSizeDeltaY;

	[SerializeField]
	private float multiChapterRectTransSizeDeltaY;

	[SerializeField]
	private float challengesHeightAddition;

	[SerializeField]
	private RectTransform noChallengesCompletionTextTarget;

	[SerializeField]
	private RectTransform challengesCompletionTextTarget;

	private int currentChapterDataIndex;

	private List<ChapterData> chapterDatas;

	private Action<int> onPressedCallback;

	private void OnEnable()
	{
	}

	public void SetCallback(Action<int> onPressedAction)
	{
	}

	public void AddChapterIndex(Zone zone, string chapterAreaNameLocKey, int chapterIndex, float completionPercent, bool isLocked, int? completedChallenges, int? totalChallenges)
	{
	}

	public bool IsMultiChapter()
	{
		return false;
	}

	public void JumpToChapterIndex(int chapterIndex)
	{
	}

	public void UGUI_ChangeIndex(int changeAmount)
	{
	}

	public void UGUI_OnPressed(Zone sourceZone)
	{
	}

	public void DEBUG_UNLOCKALL()
	{
	}

	private void Refresh()
	{
	}
}
