namespace Bolt
{
	public class BitSet : BoltObject
	{
		public const int BITSET_LONGS = 16;

		internal static readonly BitSet Full;

		private ulong Bits0;

		private ulong Bits1;

		private ulong Bits2;

		private ulong Bits3;

		private ulong Bits4;

		private ulong Bits5;

		private ulong Bits6;

		private ulong Bits7;

		private ulong Bits8;

		private ulong Bits9;

		private ulong Bits10;

		private ulong Bits11;

		private ulong Bits12;

		private ulong Bits13;

		private ulong Bits14;

		private ulong Bits15;

		public bool IsZero => false;

		public ulong Item
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		static BitSet()
		{
		}

		public BitSet(ulong bits0, ulong bits1, ulong bits2, ulong bits3, ulong bits4, ulong bits5, ulong bits6, ulong bits7, ulong bits8, ulong bits9, ulong bits10, ulong bits11, ulong bits12, ulong bits13, ulong bits14, ulong bits15)
		{
		}

		public BitSet()
		{
		}

		public void Set(int bit)
		{
		}

		public void Clear(int bit)
		{
		}

		public void Combine(BitSet other)
		{
		}

		public void ClearAll()
		{
		}

		public bool IsSet(int bit)
		{
			return false;
		}
	}
}
