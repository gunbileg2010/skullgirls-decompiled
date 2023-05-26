using UnityEngine;

public class UISheen : MonoBehaviour
{
	[SerializeField]
	private Material material;

	[SerializeField]
	private float intervalSeconds;

	[SerializeField]
	private int sheenCount;

	[SerializeField]
	private float sheenDurationSeconds;

	private float timer;

	private bool doingSheens;

	private int sheenCounter;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SetMaterial(Material material)
	{
	}
}
