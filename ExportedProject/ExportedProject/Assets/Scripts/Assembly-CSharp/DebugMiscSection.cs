using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMiscSection : MonoBehaviour
{
	[SerializeField]
	private GameObject debugWindowGO;

	[SerializeField]
	private SGMatch syncMatch;

	[SerializeField]
	private Toggle replayChecksumToggle;

	[SerializeField]
	private Toggle forceOfferPopupsToggle;

	[SerializeField]
	private InputField replaySkipToFrame;

	[SerializeField]
	private Text offersLabelPrototype;

	[SerializeField]
	private InputField matchModifierLocTestStartIndex;

	[SerializeField]
	private InputField matchModifierLocTestEndIndex;

	private DebugSettings debugSettings;

	private List<Text> offerLabels;

	protected void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void CloseWindow()
	{
	}

	public void UGUI_TutorialsClicked()
	{
	}

	public void UGUI_CombatDemoClicked()
	{
	}

	public void UGUI_ReplayChecksumToggle(bool isOn)
	{
	}

	public void UGUI_ReplaySetSkipToFramePressed()
	{
	}

	public void UGUI_SyncTestPvpButtonPressed()
	{
	}

	public void UGUI_ForceShowOfferPopupsToggle(bool isOn)
	{
	}

	public void UGUI_ResetShownOffersPressed()
	{
	}

	public void UGUI_ShowTestDialogue(StoryDialogPopupData popupData)
	{
	}

	public void UGUI_MatchModifierLocTest()
	{
	}

	private void RefreshOffersDisplay()
	{
	}
}
