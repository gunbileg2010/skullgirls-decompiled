public static class DeviceMetricsUtil
{
	public static void GetInternalDeviceMetricsReport(out int result, out string context)
	{
		result = default(int);
		context = null;
	}

	private static bool IsFSIAvailable(ref string context)
	{
		return false;
	}

	private static byte GetOS()
	{
		return 0;
	}

	private static bool GetOSStatus(ref string context)
	{
		return false;
	}
}
