using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Popup : MonoBehaviour, IPopup
{
	protected PopupData popupData;

	protected int currentQueueNumber;

	private bool inputAllowed;

	public event Action<IPopup> ShowEvent
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

	public event Action<IPopup> HideEvent
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

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	public virtual void Back()
	{
	}

	public PopupData GetData()
	{
		return null;
	}

	public virtual void SetData(PopupData newPopupData)
	{
	}

	public int GetQueueNumber()
	{
		return 0;
	}

	public void SetQueueNumber(int newLayer)
	{
	}

	public void SetInputAllowed(bool allowed)
	{
	}

	public bool IsInputAllowed()
	{
		return false;
	}

	public virtual int GetSortingOrder()
	{
		return 0;
	}

	public virtual void SetSortingOrder(int sortingOrder)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	protected virtual void ButtonPressed(int index)
	{
	}

	private void OnActiveSceneChanged(Scene from, Scene to)
	{
	}
}
