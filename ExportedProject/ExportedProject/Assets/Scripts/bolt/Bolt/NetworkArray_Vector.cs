using UnityEngine;

namespace Bolt
{
	[Documentation]
	public class NetworkArray_Vector : NetworkArray_Values<Vector3>
	{
		internal NetworkArray_Vector(int length, int stride)
		{
			((NetworkArray_Values<>)(object)this)._002Ector(0, 0);
		}

		protected override Vector3 GetValue(int index)
		{
			return default(Vector3);
		}

		protected override bool SetValue(int index, Vector3 value)
		{
			return false;
		}
	}
}
