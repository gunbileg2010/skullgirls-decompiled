using System.IO;

public struct IntVector2
{
	public int x;

	public int y;

	public static IntVector2 Zero => default(IntVector2);

	public IntVector2(int _x, int _y)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void ReadFromFile(BinaryReader reader)
	{
	}
}
