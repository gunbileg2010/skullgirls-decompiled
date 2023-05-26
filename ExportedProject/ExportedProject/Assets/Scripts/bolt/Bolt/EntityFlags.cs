namespace Bolt
{
	[Documentation]
	public struct EntityFlags
	{
		public static readonly EntityFlags ZERO;

		public static readonly EntityFlags HAS_CONTROL;

		public static readonly EntityFlags PERSIST_ON_LOAD;

		public static readonly EntityFlags ATTACHED;

		public static readonly EntityFlags CONTROLLER_LOCAL_PREDICTION;

		public static readonly EntityFlags SCENE_OBJECT;

		private readonly int bits;

		public bool IsZero => false;

		private EntityFlags(int val)
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

		public static implicit operator bool(EntityFlags a)
		{
			return false;
		}

		public static explicit operator int(EntityFlags a)
		{
			return 0;
		}

		public static explicit operator EntityFlags(int a)
		{
			return default(EntityFlags);
		}

		public static EntityFlags operator &(EntityFlags a, EntityFlags b)
		{
			return default(EntityFlags);
		}

		public static EntityFlags operator |(EntityFlags a, EntityFlags b)
		{
			return default(EntityFlags);
		}

		public static EntityFlags operator ^(EntityFlags a, EntityFlags b)
		{
			return default(EntityFlags);
		}

		public static EntityFlags operator ~(EntityFlags a)
		{
			return default(EntityFlags);
		}

		public static bool operator ==(EntityFlags a, EntityFlags b)
		{
			return false;
		}

		public static bool operator !=(EntityFlags a, EntityFlags b)
		{
			return false;
		}
	}
}
