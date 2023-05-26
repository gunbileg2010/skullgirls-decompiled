using System.Collections.Generic;
using UnityEngine;

namespace Bolt
{
	[CreateAssetMenu]
	public class PrefabDatabase : ScriptableObject
	{
		private static PrefabDatabase _instance;

		private static Dictionary<PrefabId, GameObject> _lookup;

		[SerializeField]
		internal PrefabDatabaseMode DatabaseMode;

		[SerializeField]
		internal GameObject[] Prefabs;

		public static PrefabDatabase Instance => null;

		internal static void BuildCache()
		{
		}

		private static void UpdateLookup()
		{
		}

		private static void LoadInstance()
		{
		}

		public static GameObject Find(PrefabId id)
		{
			return null;
		}

		internal static bool Contains(BoltEntity entity)
		{
			return false;
		}
	}
}
