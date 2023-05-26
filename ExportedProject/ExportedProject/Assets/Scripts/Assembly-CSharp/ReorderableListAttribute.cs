using UnityEngine;

public class ReorderableListAttribute : PropertyAttribute
{
	public Color[] labelColors;

	public ReorderableListAttribute()
	{
	}

	public ReorderableListAttribute(params float[] colors)
	{
	}
}
