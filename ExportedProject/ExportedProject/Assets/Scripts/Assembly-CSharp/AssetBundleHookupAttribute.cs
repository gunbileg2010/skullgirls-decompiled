using System;
using UnityEngine;

public class AssetBundleHookupAttribute : PropertyAttribute
{
	public Type referencedType;

	public AssetBundleHookupAttribute(Type referencedType)
	{
	}
}
