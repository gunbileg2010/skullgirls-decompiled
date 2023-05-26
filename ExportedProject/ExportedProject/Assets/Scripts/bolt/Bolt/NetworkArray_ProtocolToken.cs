namespace Bolt
{
	[Documentation]
	public class NetworkArray_ProtocolToken : NetworkArray_Values<IProtocolToken>
	{
		internal NetworkArray_ProtocolToken(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override IProtocolToken GetValue(int index)
		{
			return null;
		}

		protected override bool SetValue(int index, IProtocolToken value)
		{
			return false;
		}
	}
}
