using System;

public class DynamicResourceTypeAttribute : Attribute
{
	public Type referencedType;

	public DynamicResourceTypeAttribute(Type referencedType)
	{
	}
}
