namespace Bolt
{
	[Documentation]
	public class NetworkArray_PrefabId : NetworkArray_Values<PrefabId>
	{
		internal NetworkArray_PrefabId(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override PrefabId GetValue(int index)
		{
			return default(PrefabId);
		}

		protected override bool SetValue(int index, PrefabId value)
		{
			return false;
		}
	}
}
