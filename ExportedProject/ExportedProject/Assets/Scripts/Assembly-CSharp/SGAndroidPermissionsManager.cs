using System;
using UnityEngine;

public class SGAndroidPermissionsManager : AndroidPermissionsManager
{
	[SerializeField]
	private PopupData presentationPopup;

	private void Awake()
	{
	}

	private void ShowPopup(string titleKey, string messageKey, Action confirmCallback, Action cancelCallback)
	{
	}
}
