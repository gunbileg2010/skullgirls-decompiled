using UnityEngine;

namespace Bolt
{
	public struct CachedComponent<T> where T : Component
	{
		private T component;

		private readonly GameObject go;

		private readonly bool children;

		public bool Exists => false;

		public T Component => null;

		public CachedComponent(GameObject gameObject, bool scanChildren)
		{
		}
	}
}
