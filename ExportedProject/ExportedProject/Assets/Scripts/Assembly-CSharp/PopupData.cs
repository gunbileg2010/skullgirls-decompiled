using System;
using System.Collections.Generic;
using UnityEngine;

public class PopupData : ScriptableObject
{
	[SerializeField]
	private GameObject popupPrefab;

	[SerializeField]
	private DynamicResource popupPrefabResource;

	[SerializeField]
	private bool destroyOnHide;

	[SerializeField]
	private bool destroyOnSceneChange;

	[SerializeField]
	private int defaultQueueNumber;

	public bool hideOnButtonPress;

	public PopupData showOnHidePopupData;

	public Dictionary<int, Action<IPopup>> buttonCallbacks;

	public object context;

	public object returnContext;

	public object tabContext;

	[HideInInspector]
	public DateTime? popupTimeout;

	[HideInInspector]
	public float changeTimerColorAtSeconds;

	[HideInInspector]
	public Color? newTimerColor;

	private static Dictionary<string, IPopup> cachedPopupInstances;

	private string instanceName;

	protected Dictionary<string, object> substituteData;

	protected Action<IPopup> showCallback;

	protected Action<IPopup> hideCallback;

	public IPopup CreatePopupInstance()
	{
		return null;
	}

	public IPopup GetPopupInstance()
	{
		return null;
	}

	public virtual int GetQueueNumber()
	{
		return 0;
	}

	public void AddSub(string subKey, object subValue)
	{
	}

	public void RemoveSub(string subKey)
	{
	}

	public string ApplySubs(string original)
	{
		return null;
	}

	public void ClearButtonCallbacks()
	{
	}

	public void AddButtonCallback(PopupButtonType buttonType, Action<IPopup> callback)
	{
	}

	public void AddButtonCallback(int index, Action<IPopup> callback)
	{
	}

	public void ClearShowHideCallbacks()
	{
	}

	public void SetShowCallback(Action<IPopup> showCallback)
	{
	}

	public void SetHideCallback(Action<IPopup> hideCallback)
	{
	}

	public void FireShowCallback(IPopup context)
	{
	}

	public void FireHideCallback(IPopup context)
	{
	}

	public void OnHide(IPopup popup)
	{
	}

	public void OnSceneChange(IPopup popup)
	{
	}

	public void DestroyPopup()
	{
	}
}
