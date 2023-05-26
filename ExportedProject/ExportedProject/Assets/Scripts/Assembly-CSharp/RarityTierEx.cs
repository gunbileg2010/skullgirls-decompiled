public static class RarityTierEx
{
	public static readonly RarityTier[] kTiersArray;

	public static int GetMaxIndex()
	{
		return 0;
	}

	public static bool IsMax(this RarityTier tier)
	{
		return false;
	}

	public static string GetLocKey(this RarityTier tier)
	{
		return null;
	}

	public static string ToLocalizedString(this RarityTier tier)
	{
		return null;
	}

	public static string ToMetricsChar(this RarityTier tier)
	{
		return null;
	}

	public static RarityTier Max(RarityTier primary, RarityTier other)
	{
		return default(RarityTier);
	}

	public static int GetLevelCap(this RarityTier tier)
	{
		return 0;
	}

	public static bool IsRare(this RarityTier tier)
	{
		return false;
	}

	public static bool IsVeryRare(this RarityTier tier)
	{
		return false;
	}

	public static bool IsUltraRare(this RarityTier tier)
	{
		return false;
	}
}
