namespace Bolt
{
	[Documentation]
	public struct CommandFlags
	{
		public static readonly CommandFlags ZERO;

		public static readonly CommandFlags HAS_EXECUTED;

		public static readonly CommandFlags SEND_STATE;

		public static readonly CommandFlags SEND_STATE_PERFORMED;

		public static readonly CommandFlags CORRECTION_RECEIVED;

		public static readonly CommandFlags DISPOSE;

		public static readonly CommandFlags MISSING;

		private readonly int bits;

		public bool IsZero => false;

		private CommandFlags(int val)
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

		public static implicit operator bool(CommandFlags a)
		{
			return false;
		}

		public static explicit operator int(CommandFlags a)
		{
			return 0;
		}

		public static explicit operator CommandFlags(int a)
		{
			return default(CommandFlags);
		}

		public static CommandFlags operator &(CommandFlags a, CommandFlags b)
		{
			return default(CommandFlags);
		}

		public static CommandFlags operator |(CommandFlags a, CommandFlags b)
		{
			return default(CommandFlags);
		}

		public static CommandFlags operator ^(CommandFlags a, CommandFlags b)
		{
			return default(CommandFlags);
		}

		public static CommandFlags operator ~(CommandFlags a)
		{
			return default(CommandFlags);
		}

		public static bool operator ==(CommandFlags a, CommandFlags b)
		{
			return false;
		}

		public static bool operator !=(CommandFlags a, CommandFlags b)
		{
			return false;
		}
	}
}
