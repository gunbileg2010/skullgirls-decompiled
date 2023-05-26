using System.IO;

public static class FixedBinaryReadWriteExtensions
{
	public static void Write(this BinaryWriter binaryWriter, Fixed fixedValue)
	{
	}

	public static Fixed ReadFixed(this BinaryReader binaryReader)
	{
		return default(Fixed);
	}

	public static void Write(this BinaryWriter binaryWriter, Fixed2 fixedValue)
	{
	}

	public static Fixed2 ReadFixed2(this BinaryReader binaryReader)
	{
		return default(Fixed2);
	}

	public static void Write(this BinaryWriter binaryWriter, Fixed3 fixedValue)
	{
	}

	public static Fixed3 ReadFixed3(this BinaryReader binaryReader)
	{
		return default(Fixed3);
	}

	public static void Write(this BinaryWriter binaryWriter, FixedBounds fixedBounds)
	{
	}

	public static FixedBounds ReadFixedBounds(this BinaryReader binaryReader)
	{
		return default(FixedBounds);
	}
}
