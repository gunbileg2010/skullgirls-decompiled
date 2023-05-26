using UnityEngine;

public class PairedDataAttribute : PropertyAttribute
{
	public string firstDataSerializationName;

	public string secondDataSerializationName;

	public PairedDataAttribute(string firstDataSerializationName, string secondDataSerializationName)
	{
	}
}
