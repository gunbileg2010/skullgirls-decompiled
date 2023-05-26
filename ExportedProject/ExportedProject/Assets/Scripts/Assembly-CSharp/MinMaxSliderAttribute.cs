using UnityEngine;

public class MinMaxSliderAttribute : PropertyAttribute
{
	public float minVal;

	public float maxVal;

	public bool allowFractions;

	public MinMaxSliderAttribute(int minVal, int maxVal)
	{
	}

	public MinMaxSliderAttribute(float minVal, float maxVal)
	{
	}
}
