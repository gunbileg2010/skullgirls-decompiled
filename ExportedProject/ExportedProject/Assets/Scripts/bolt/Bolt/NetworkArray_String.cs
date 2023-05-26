namespace Bolt
{
	[Documentation]
	public class NetworkArray_String : NetworkArray_Values<string>
	{
		internal NetworkArray_String(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override string GetValue(int index)
		{
			return null;
		}

		protected override bool SetValue(int index, string value)
		{
			return false;
		}
	}
}
