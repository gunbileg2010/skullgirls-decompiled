using System.Collections.Generic;

namespace DamienG.Security.Cryptography
{
	internal static class Crc32
	{
		public const uint DefaultSeed = uint.MaxValue;

		public const uint DefaultPolynomial = 3988292384u;

		private static uint[] defaultTable;

		public static uint Compute(byte[] buffer)
		{
			return 0u;
		}

		public static uint Compute(uint seed, byte[] buffer)
		{
			return 0u;
		}

		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			return 0u;
		}

		private static uint[] InitializeTable(uint polynomial)
		{
			return null;
		}

		private static uint CalculateHash(uint[] table, uint seed, IList<byte> buffer, int start, int size)
		{
			return 0u;
		}

		private static byte[] UInt32ToBigEndianBytes(uint uint32)
		{
			return null;
		}
	}
}
