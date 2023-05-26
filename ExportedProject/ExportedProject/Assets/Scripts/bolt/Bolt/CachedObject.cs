using UnityEngine;

namespace Bolt
{
	public struct CachedObject<T> where T : Component
	{
		private T component;

		private float lastCheck;

		public bool Exists => false;

		public T Component => null;
	}
}
