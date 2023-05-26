using System.Runtime.InteropServices;

namespace Bolt
{
	[StructLayout(2)]
	internal struct NetworkTrigger
	{
		[FieldOffset(0)]
		public int Frame;

		[FieldOffset(4)]
		public int History;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void Update(int frame, bool set)
		{
		}

		public static bool operator ==(NetworkTrigger a, NetworkTrigger b)
		{
			return false;
		}

		public static bool operator !=(NetworkTrigger a, NetworkTrigger b)
		{
			return false;
		}
	}
}
