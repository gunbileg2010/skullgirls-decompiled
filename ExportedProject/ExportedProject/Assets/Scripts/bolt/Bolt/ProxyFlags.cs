namespace Bolt
{
	[Documentation]
	public struct ProxyFlags
	{
		public static readonly ProxyFlags ZERO;

		public static readonly ProxyFlags CREATE_REQUESTED;

		public static readonly ProxyFlags CREATE_DONE;

		public static readonly ProxyFlags DESTROY_REQUESTED;

		public static readonly ProxyFlags DESTROY_PENDING;

		public static readonly ProxyFlags DESTROY_IGNORE;

		public static readonly ProxyFlags IDLE;

		public static readonly ProxyFlags FORCE_SYNC;

		private readonly int bits;

		public bool IsZero => false;

		private ProxyFlags(int val)
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

		public static implicit operator bool(ProxyFlags a)
		{
			return false;
		}

		public static explicit operator int(ProxyFlags a)
		{
			return 0;
		}

		public static explicit operator ProxyFlags(int a)
		{
			return default(ProxyFlags);
		}

		public static ProxyFlags operator &(ProxyFlags a, ProxyFlags b)
		{
			return default(ProxyFlags);
		}

		public static ProxyFlags operator |(ProxyFlags a, ProxyFlags b)
		{
			return default(ProxyFlags);
		}

		public static ProxyFlags operator ^(ProxyFlags a, ProxyFlags b)
		{
			return default(ProxyFlags);
		}

		public static ProxyFlags operator ~(ProxyFlags a)
		{
			return default(ProxyFlags);
		}

		public static bool operator ==(ProxyFlags a, ProxyFlags b)
		{
			return false;
		}

		public static bool operator !=(ProxyFlags a, ProxyFlags b)
		{
			return false;
		}
	}
}
