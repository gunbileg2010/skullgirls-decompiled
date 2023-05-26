using UnityEngine;

namespace Bolt
{
	[Documentation]
	public class NetworkArray_Quaternion : NetworkArray_Values<Quaternion>
	{
		internal NetworkArray_Quaternion(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override Quaternion GetValue(int index)
		{
			return default(Quaternion);
		}

		protected override bool SetValue(int index, Quaternion value)
		{
			return false;
		}
	}
}
