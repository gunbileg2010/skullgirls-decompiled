using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContextualTutorial : MonoBehaviour
{
	[Serializable]
	public class ContextualTutorialStep
	{
		public RectTransform position;

		public string header;

		public string message;

		public bool setFrameTint;

		public Color frameTint;
	}

	[SerializeField]
	private GameObject contextualPopupPrefab;

	[SerializeField]
	private float delay;

	[SerializeField]
	private float delayBetweenSteps;

	[SerializeField]
	private float width;

	[SerializeField]
	private bool clearBackground;

	[SerializeField]
	private bool showEveryTime;

	[SerializeField]
	private TalkingHeadController talkingHeadController;

	public List<ContextualTutorialStep> steps;

	private int stepIndex;

	private GameObject contextualPopupGO;

	private ContextualPopupItem contextualPopup;

	private string gameStateName;

	private bool showing;

	private bool isRunning;

	private bool initialized;

	private bool isFirstVisit;

	private string currentContext;

	private Image inputBlockingImage;

	private Action onCompleteCallback;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public bool IsRunning()
	{
		return false;
	}

	public bool Show(string contextName = null, bool forceShow = false, Action onCompleteCallback = null)
	{
		return false;
	}

	private IEnumerator StartTutorial()
	{
		return null;
	}

	private void OnComplete()
	{
	}

	private IEnumerator DoNextAction()
	{
		return null;
	}

	private void CleanUp()
	{
	}

	private void ShowPopup()
	{
	}

	private void OnBackButtonPressed()
	{
	}
}
