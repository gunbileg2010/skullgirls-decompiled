using System.Collections.Generic;

public static class Canary
{
	private static List<string> expectedApkAssets;

	private static List<string> expectedApkLibs;

	private static List<string> unexpectedFiles;

	public static bool Initialize(ref string context)
	{
		return false;
	}

	private static void InspectApkContents()
	{
	}
}
