using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoModeSelectScreen : MonoBehaviour
{
	[SerializeField]
	private Fight quickmatch;

	[SerializeField]
	private Fight dummyFight;

	[SerializeField]
	private GameObject localPvpButtonGO;

	[SerializeField]
	private StageSet allStagesSet;

	[SerializeField]
	private ToggleGroup stageSelectToggleGroup;

	[SerializeField]
	private Toggle stageSelectItemPrototype;

	private Toggle[] stageToggles;

	private List<Stage> stages;

	private void Awake()
	{
	}

	public void UGUI_QuickmatchButtonPressed()
	{
	}

	public void UGUI_DummyFightButtonPressed()
	{
	}

	public void UGUI_VersusButtonPressed()
	{
	}

	public void UGUI_TEMPLocalPvp()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private Stage GetSelectedStage()
	{
		return null;
	}
}
