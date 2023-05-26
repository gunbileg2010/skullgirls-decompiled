namespace Bolt
{
	[Documentation]
	public class NetworkArray_Entity : NetworkArray_Values<BoltEntity>
	{
		internal NetworkArray_Entity(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override BoltEntity GetValue(int index)
		{
			return null;
		}

		protected override bool SetValue(int index, BoltEntity value)
		{
			return false;
		}
	}
}
