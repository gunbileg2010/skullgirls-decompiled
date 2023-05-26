namespace Bolt
{
	internal struct DoubleBuffer<T> where T : struct
	{
		public T Previous;

		public T Current;

		public DoubleBuffer<T> Shift(T value)
		{
			return default(DoubleBuffer<T>);
		}

		public static DoubleBuffer<T> InitBuffer(T value)
		{
			return default(DoubleBuffer<T>);
		}
	}
}
