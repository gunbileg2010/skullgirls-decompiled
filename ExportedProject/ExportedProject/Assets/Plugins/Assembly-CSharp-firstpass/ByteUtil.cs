public static class ByteUtil
{
	private const float kBytesToMBFactor = 1048576f;

	public static short BytesToShort(byte first, byte second)
	{
		return 0;
	}

	public static ushort BytesToUShort(byte first, byte second)
	{
		return 0;
	}

	public static int BytesToInt(byte first, byte second, byte third, byte fourth)
	{
		return 0;
	}

	public static int BytesToInt(byte[] bytes)
	{
		return 0;
	}

	public static uint BytesToUInt(byte first, byte second, byte third, byte fourth)
	{
		return 0u;
	}

	public static void ShortToTwoBytes(short val, byte[] bytes, int offset = 0)
	{
	}

	public static void IntToFourBytes(int val, byte[] bytes, int offset = 0)
	{
	}

	public static void UShortToTwoBytes(ushort val, byte[] bytes, int offset = 0, bool makeBigEndian = false)
	{
	}

	public static void UIntToFourBytes(uint val, byte[] bytes, int offset = 0, bool makeBigEndian = false)
	{
	}

	public static void ULongToEightBytes(ulong val, byte[] bytes, int offset = 0, bool makeBigEndian = false)
	{
	}

	private static void SwapBytesInArray(byte[] bytes, int indexA, int indexB)
	{
	}

	public static float BytesToMB(int bytes)
	{
		return 0f;
	}

	public static uint FloatToUInt(float floatVal)
	{
		return 0u;
	}

	public static float UIntToFloat(uint value)
	{
		return 0f;
	}

	public static string ToHex(this byte[] bytes)
	{
		return null;
	}

	public static void OutputByteString(string label, byte[] bytes)
	{
	}
}
