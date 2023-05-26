namespace Bolt
{
	[Documentation]
	public struct InstantiateFlags
	{
		public static readonly InstantiateFlags ZERO;

		public static readonly InstantiateFlags TAKE_CONTROL;

		public static readonly InstantiateFlags ASSIGN_CONTROL;

		private readonly int bits;

		public bool IsZero => false;

		private InstantiateFlags(int val)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator bool(InstantiateFlags a)
		{
			return false;
		}

		public static explicit operator int(InstantiateFlags a)
		{
			return 0;
		}

		public static explicit operator InstantiateFlags(int a)
		{
			return default(InstantiateFlags);
		}

		public static InstantiateFlags operator &(InstantiateFlags a, InstantiateFlags b)
		{
			return default(InstantiateFlags);
		}

		public static InstantiateFlags operator |(InstantiateFlags a, InstantiateFlags b)
		{
			return default(InstantiateFlags);
		}

		public static InstantiateFlags operator ^(InstantiateFlags a, InstantiateFlags b)
		{
			return default(InstantiateFlags);
		}

		public static InstantiateFlags operator ~(InstantiateFlags a)
		{
			return default(InstantiateFlags);
		}

		public static bool operator ==(InstantiateFlags a, InstantiateFlags b)
		{
			return false;
		}

		public static bool operator !=(InstantiateFlags a, InstantiateFlags b)
		{
			return false;
		}
	}
}
