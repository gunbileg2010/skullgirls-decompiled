using System.Collections.Generic;

public static class BoltScenes
{
	internal static readonly Dictionary<string, int> nameLookup;

	internal static readonly Dictionary<int, string> indexLookup;

	public const string _0xStartup = "0xStartup";

	public const string _1xFight = "1xFight";

	public static IEnumerable<string> AllScenes => null;

	static BoltScenes()
	{
	}

	public static void AddScene(short prefix, short id, string name)
	{
	}
}
