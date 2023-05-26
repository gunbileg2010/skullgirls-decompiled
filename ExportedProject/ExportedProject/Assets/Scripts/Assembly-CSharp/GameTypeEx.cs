public static class GameTypeEx
{
	public static bool IsActBased(this GameType gameType)
	{
		return false;
	}

	public static bool IsEventBased(this GameType gameType)
	{
		return false;
	}

	public static bool RequiresPrepFight(this GameType gameType)
	{
		return false;
	}

	public static bool RequiresStartFight(this GameType gameType)
	{
		return false;
	}

	public static bool RequiresEndFight(this GameType gameType)
	{
		return false;
	}

	public static bool IsOnline(this GameType gameType)
	{
		return false;
	}

	public static string ToMetricsGameMode(this GameType gameType)
	{
		return null;
	}

	public static string GetLocKey(this GameType gameType)
	{
		return null;
	}
}
