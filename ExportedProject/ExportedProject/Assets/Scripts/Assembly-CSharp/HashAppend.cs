using System.IO;

public class HashAppend
{
	public enum AppendType : byte
	{
		NONE = 0,
		MY_NAME = 1,
		MY_POINT_NAME = 2,
		ENEMY_POINT_NAME = 3,
		ATTACKER_NAME = 4
	}

	private uint hash;

	private AppendType appendType;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public uint GetHash()
	{
		return 0u;
	}

	public uint GetHash(Actor actor)
	{
		return 0u;
	}
}
