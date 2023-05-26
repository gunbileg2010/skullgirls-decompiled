namespace Bolt
{
	[Documentation]
	public class NetworkArray_Float : NetworkArray_Values<float>
	{
		internal NetworkArray_Float(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override float GetValue(int index)
		{
			return 0f;
		}

		protected override bool SetValue(int index, float value)
		{
			return false;
		}
	}
}
