using System.Collections.Generic;

public class LootValueEqualityComparer : IEqualityComparer<Loot>
{
	public bool Equals(Loot a, Loot b)
	{
		return false;
	}

	public int GetHashCode(Loot loot)
	{
		return 0;
	}
}
