using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
	public class DummyGameState : IGameState
	{
		public string StateName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IEnumerator Show(IGameState previousState, object context)
		{
			return null;
		}

		public IEnumerator Hide(IGameState nextState)
		{
			return null;
		}
	}

	[SerializeField]
	private string startStateName;

	private readonly Dictionary<string, IGameState> cachedStates;

	private readonly Stack<string> stateStack;

	private readonly Stack<object> stateContextStack;

	private string currentStateName;

	private object currentStateContext;

	private readonly DummyGameState dummyToState;

	private readonly DummyGameState dummyFromState;

	private Coroutine transitionsCoroutine;

	public event Action<string, string> PreStateChanged
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

	public event Action<string, string> StateChanged
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

	private void Start()
	{
	}

	public void RegisterState(string stateName, IGameState state)
	{
	}

	public void UnregisterState(string stateName)
	{
	}

	public void SetState(string newStateName, object context = null, bool force = false)
	{
	}

	public void SetStateWithoutTransition(string newStateName, object context = null)
	{
	}

	public bool PushState(string newStateName, object context = null, bool force = false)
	{
		return false;
	}

	public bool PushStateWithoutTransition(string newStateName, object context = null)
	{
		return false;
	}

	public bool PopState(bool force = false)
	{
		return false;
	}

	public bool PopStateWithoutTransition()
	{
		return false;
	}

	public bool PopStateToRoot(bool force)
	{
		return false;
	}

	public bool PopStateUntil(string stateName, bool force = false)
	{
		return false;
	}

	public void ClearStateHistory()
	{
	}

	public bool ClearStateHistoryUntil(string untilStateName)
	{
		return false;
	}

	public string GetCurrentStateName()
	{
		return null;
	}

	public bool IsTransitioning()
	{
		return false;
	}

	public bool IsStateInStack(string stateName)
	{
		return false;
	}

	private void TransitionToState(string toStateName, object toStateContext)
	{
	}

	private IEnumerator DoStateTransitions(IGameState fromState, IGameState toState, object toContext)
	{
		return null;
	}

	private void OnActiveSceneChanged(Scene from, Scene to)
	{
	}
}
