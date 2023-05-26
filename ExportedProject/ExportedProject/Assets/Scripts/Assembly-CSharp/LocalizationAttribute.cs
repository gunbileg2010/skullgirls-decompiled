using UnityEngine;

public class LocalizationAttribute : PropertyAttribute
{
	public bool readOnly;

	public bool drawAsTextArea;

	public string[] variations;

	public LocalizationAttribute(bool readOnly = false, bool drawAsTextArea = false)
	{
	}

	public LocalizationAttribute(bool readOnly, bool drawAsTextArea, params string[] variations)
	{
	}
}
