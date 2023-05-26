public static class CharacterCalcUtil
{
	private static GameSettings gameSettings;

	static CharacterCalcUtil()
	{
	}

	public static long GetExperienceNeededForLevel(int level, bool isShiny, RarityTier tier = RarityTier.Bronze)
	{
		return 0L;
	}

	public static int GetLevelForExperience(long experience, bool isShiny, RarityTier tier = RarityTier.Bronze)
	{
		return 0;
	}

	public static float GetFloatLevelForExperience(long experience, bool isShiny, RarityTier tier)
	{
		return 0f;
	}

	public static float ApplyLevelAttackScaling(float attack, int level)
	{
		return 0f;
	}

	public static float ApplyLevelLifebarScaling(float lifebar, int level)
	{
		return 0f;
	}

	public static float CalculateLongshotMultiplier(Team playerTeam, Team enemyTeam)
	{
		return 0f;
	}

	public static long GetHalvedValueCeiling(long value)
	{
		return 0L;
	}

	private static void IterateLevelLadder(int? targetLevel, long? targetExperience, bool isShiny, RarityTier tier, out int resultLevel, out long resultExperience)
	{
		resultLevel = default(int);
		resultExperience = default(long);
	}
}
