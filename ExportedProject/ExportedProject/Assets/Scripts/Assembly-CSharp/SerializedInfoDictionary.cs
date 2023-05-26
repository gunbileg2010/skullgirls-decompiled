using System.Collections.Generic;
using System.Runtime.Serialization;

public class SerializedInfoDictionary
{
	private Dictionary<string, object> contents;

	public SerializedInfoDictionary(SerializationInfo info)
	{
	}

	public T GetValue<T>(string name, T defaultValue)
	{
		return default(T);
	}

	public object GetValue(string name, object defaultValue)
	{
		return null;
	}

	public object GetValue(string name)
	{
		return null;
	}
}
