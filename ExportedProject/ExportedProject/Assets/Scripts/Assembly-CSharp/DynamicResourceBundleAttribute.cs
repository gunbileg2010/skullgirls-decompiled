using System;

public class DynamicResourceBundleAttribute : Attribute
{
	public string bundleName;

	public DynamicResourceBundleAttribute(string bundleName)
	{
	}
}
