using UnityEngine;
using UnityEngine.UI;

public class UIComponentToggle : MonoBehaviour
{
	[SerializeField]
	private Toggle toggleParent;

	[SerializeField]
	private MonoBehaviour[] onWithToggle;

	[SerializeField]
	private MonoBehaviour[] offWithToggle;

	private void OnEnable()
	{
	}

	public void UGUI_Toggle(bool value)
	{
	}
}
