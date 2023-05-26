using UnityEngine;
using UnityEngine.UI;

public class ToggleGradientHighlight : MonoBehaviour
{
	[SerializeField]
	private Toggle toggle;

	[SerializeField]
	private UIGradient gradient;

	[SerializeField]
	private Gradient offGradient;

	[SerializeField]
	private Gradient onGradient;

	public void OnEnable()
	{
	}

	public void UGUI_OnToggleChange(bool value)
	{
	}
}
