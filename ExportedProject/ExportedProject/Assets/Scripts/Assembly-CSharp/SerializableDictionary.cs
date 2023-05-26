using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[Serializable]
public class SerializableDictionary<T, U> : Dictionary<T, U>, ISerializable
{
	private const string KEYS = "keys";

	private const string VALUES = "values";

	public SerializableDictionary()
	{
		((Dictionary<TKey, TValue>)(object)this)._002Ector();
	}

	public SerializableDictionary(SerializationInfo info, StreamingContext ctxt)
	{
		((Dictionary<TKey, TValue>)(object)this)._002Ector();
	}

	public new void GetObjectData(SerializationInfo info, StreamingContext ctxt)
	{
	}
}
