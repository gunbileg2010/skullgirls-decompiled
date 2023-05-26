using System;
using System.Collections.Generic;

public class EventManager
{
	private Dictionary<string, Action<object>> eventTable;

	public void Subscribe(string eventName, Action<object> callback)
	{
	}

	public void Unsubscribe(string eventName, Action<object> callback)
	{
	}

	public void Publish(string eventName, object passedData)
	{
	}
}
