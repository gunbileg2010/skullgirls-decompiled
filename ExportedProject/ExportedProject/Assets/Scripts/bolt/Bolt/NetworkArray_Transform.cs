namespace Bolt
{
	[Documentation]
	public class NetworkArray_Transform : NetworkArray_Values<NetworkTransform>
	{
		public new NetworkTransform Item => null;

		internal NetworkArray_Transform(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override NetworkTransform GetValue(int index)
		{
			return null;
		}

		protected override bool SetValue(int index, NetworkTransform value)
		{
			return false;
		}
	}
}
