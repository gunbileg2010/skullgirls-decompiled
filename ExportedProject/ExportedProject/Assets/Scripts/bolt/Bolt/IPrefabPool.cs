using UnityEngine;

namespace Bolt
{
	public interface IPrefabPool
	{
		GameObject LoadPrefab(PrefabId prefabId);

		GameObject Instantiate(PrefabId prefabId, Vector3 position, Quaternion rotation);

		void Destroy(GameObject gameObject);
	}
}
