namespace Bolt
{
	internal struct Scene
	{
		public readonly int Index;

		public readonly int Sequence;

		public Scene(int index, int sequence)
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

		public static bool operator ==(Scene a, Scene b)
		{
			return false;
		}

		public static bool operator !=(Scene a, Scene b)
		{
			return false;
		}
	}
}
