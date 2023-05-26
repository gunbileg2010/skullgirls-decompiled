using UnityEngine.UI;

public static class UISetExtensions
{
	private static Slider.SliderEvent emptySliderEvent;

	private static Toggle.ToggleEvent emptyToggleEvent;

	private static InputField.OnChangeEvent emptyInputFieldEvent;

	private static Dropdown.DropdownEvent emptyDropdownEvent;

	public static void SetValue(this Slider instance, float value)
	{
	}

	public static void SetValue(this Toggle instance, bool value)
	{
	}

	public static void SetValue(this InputField instance, string value)
	{
	}

	public static void SetValue(this Dropdown instance, int value)
	{
	}
}
