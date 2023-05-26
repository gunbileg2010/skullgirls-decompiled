using System;
using UnityEngine;

public class FightReplayView : MonoBehaviour
{
	[SerializeField]
	private FightHistoryView fightHistoryView;

	[SerializeField]
	private LocalizedUGUIText headerText;

	private Action playCallback;

	private Action deleteCallback;

	private Action shareCallback;

	public void Populate(FightReplayServerData serverData)
	{
	}

	public void PopulateFromLocalReplay(string replayFileName)
	{
	}

	public void SetHeader(string header)
	{
	}

	public void ClearCallbacks()
	{
	}

	public void SetPlayCallback(Action callback)
	{
	}

	public void SetDeleteCallback(Action callback)
	{
	}

	public void SetShareCallback(Action callback)
	{
	}

	public void UGUI_PlayButtonPressed()
	{
	}

	public void UGUI_DeleteButtonPressed()
	{
	}

	public void UGUI_ShareButtonPressed()
	{
	}
}
