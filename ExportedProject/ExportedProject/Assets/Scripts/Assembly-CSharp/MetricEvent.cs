using System;
using System.Collections.Generic;

public struct MetricEvent
{
	public string name;

	private Dictionary<string, object> parameters;

	public MetricEvent(string eventName)
	{
	}

	public MetricEvent AddParam(string key, bool value)
	{
		return default(MetricEvent);
	}

	public MetricEvent AddParam(string key, long value)
	{
		return default(MetricEvent);
	}

	public MetricEvent AddParam(string key, double value)
	{
		return default(MetricEvent);
	}

	public MetricEvent AddParam(string key, string value)
	{
		return default(MetricEvent);
	}

	public MetricEvent AddParam(string key, DateTime value)
	{
		return default(MetricEvent);
	}

	public void Send()
	{
	}

	private void VerifyParameters()
	{
	}
}
