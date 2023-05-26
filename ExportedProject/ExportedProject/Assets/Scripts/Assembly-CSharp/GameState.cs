using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameState : MonoBehaviour, IGameState
{
	private List<Func<IGameState, object, IEnumerator>> stateEntered;

	private List<Func<IGameState, IEnumerator>> stateExited;

	[SerializeField]
	private string stateName;

	private IGameState lastPrevState;

	private object lastContext;

	private bool showInProgress;

	private bool setInactiveOnExit;

	private bool isActive;

	private List<Coroutine> coroutines;

	public string StateName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public event Func<IGameState, object, IEnumerator> StateEntered
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Func<IGameState, IEnumerator> StateExited
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public IEnumerator Show(IGameState previousState, object context)
	{
		return null;
	}

	public IEnumerator Hide(IGameState nextState)
	{
		return null;
	}

	public void ShouldSetInactiveOnExit(bool trueOrFalse)
	{
	}

	public bool IsActiveState()
	{
		return false;
	}

	public void SetGameState(string stateName)
	{
	}

	public void PushGameState(string stateName)
	{
	}

	public void PopGameState()
	{
	}
}
