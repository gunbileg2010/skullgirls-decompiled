using System;
using UnityEngine;

public class ResourcesHookup : PropertyAttribute
{
	public Type referencedType;

	public ResourcesHookup(Type referencedType)
	{
	}
}
