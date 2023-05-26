using UnityEngine;

public class SimpleSpin : MonoBehaviour
{
	[SerializeField]
	private Vector3 angularSpinPerSecond;

	[SerializeField]
	private bool resetOnDisable;

	private Quaternion startRot;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
