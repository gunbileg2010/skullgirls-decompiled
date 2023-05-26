using System;
using UnityEngine;
using UnityEngine.UI;

public class AccountBindingRow : MonoBehaviour
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Toggle isBoundToggle;

	[SerializeField]
	private LocalizedUGUIText statusText;

	[SerializeField]
	private AdvancedButton button;

	private void Awake()
	{
	}

	public void SetActive(bool active)
	{
	}

	public void SetBackgroundEnabled(bool enabled)
	{
	}

	public void SetIsBound(bool bound)
	{
	}

	public void SetStatusText(string text)
	{
	}

	public void SetButton(string text, ButtonType type, Action callback)
	{
	}
}
