using UnityEngine;

public class InstantiatePrefabSequentialAction : SequentialAction
{
	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private bool dontDestroyOnLoad;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
