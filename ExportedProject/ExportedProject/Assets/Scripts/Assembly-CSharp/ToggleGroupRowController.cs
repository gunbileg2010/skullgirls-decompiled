using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupRowController : MonoBehaviour
{
	[SerializeField]
	private RectTransform underline;

	[SerializeField]
	private AudioClip toggleSound;

	private ToggleGroup toggleGroup;

	private Toggle initialToggle;

	private bool resetting;

	private Toggle lastActiveToggle;

	private AnimatePosition underlineAnim;

	private EZAnimateFloat underlineSizeAnim;

	public event Action<Toggle> ToggleActivated
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

	private void OnEnable()
	{
	}

	public void ResetToInitialState()
	{
	}

	public void ActivateToggle(Toggle toggle)
	{
	}

	public void ForceRefresh()
	{
	}

	public void UGUI_OnToggleValueChanged(bool isOn)
	{
	}

	private void MoveUnderlineToImmediate(RectTransform target)
	{
	}

	private void MoveUnderlineTo(RectTransform target)
	{
	}
}
