namespace Bolt
{
	[Documentation]
	public class NetworkArray_Integer : NetworkArray_Values<int>
	{
		internal NetworkArray_Integer(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override int GetValue(int index)
		{
			return 0;
		}

		protected override bool SetValue(int index, int value)
		{
			return false;
		}
	}
}
