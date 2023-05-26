using UnityEngine;

public class ButtonAttribute : PropertyAttribute
{
	public ButtonPlacement placement;

	public string buttonText;

	public string methodName;

	public object[] parameters;

	public ButtonAttribute(string buttonText, string methodName, params object[] parameters)
	{
	}

	public ButtonAttribute(ButtonPlacement placement, string buttonText, string methodName, params object[] parameters)
	{
	}
}
