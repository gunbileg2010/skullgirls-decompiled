using System;
using System.Collections.Generic;

public class ScheduleServerData
{
	public bool isCurrentlyActive;

	public DateTime startDate;

	public DateTime endDate;

	public ScheduleServerData(Dictionary<string, object> data)
	{
	}

	public bool IsValid()
	{
		return false;
	}
}
