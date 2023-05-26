using System;
using UnityEngine;

public class SGInputManager : MonoSingleton<SGInputManager>
{
	private bool backButtonDisabled;

	private bool viewingFTUEPopup;

	private Canvas inputBlockerCanvas;

	private Action highPriorityCustomCallback;

	private Action lowPriorityCustomCallback;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	public void PressBackButton()
	{
	}

	public void SetHighPriorityCustomCallback(Action callback)
	{
	}

	public void SetLowPriorityCustomCallback(Action callback)
	{
	}

	public void SetBackButtonDisabled(bool disabled)
	{
	}

	public void SetViewingFTUEPopup(bool viewingFTUEPopup)
	{
	}

	public void DisableInput()
	{
	}

	public void EnableInput()
	{
	}

	public SGInputManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
