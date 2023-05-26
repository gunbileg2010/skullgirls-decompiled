using System;
using UnityEngine;

public class MaskAttribute : PropertyAttribute
{
	public string[] maskNames;

	public MaskAttribute(Type enumType)
	{
	}

	public MaskAttribute(string[] names)
	{
	}
}
