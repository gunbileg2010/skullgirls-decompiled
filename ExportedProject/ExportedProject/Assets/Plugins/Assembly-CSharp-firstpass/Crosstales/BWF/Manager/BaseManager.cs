using UnityEngine;

namespace Crosstales.BWF.Manager
{
	[ExecuteInEditMode]
	public abstract class BaseManager : MonoBehaviour
	{
		public string MarkPrefix;

		public string MarkPostfix;

		public bool DontDestroy;
	}
}
