using UnityEngine;

public class Orbiter : MonoBehaviour
{
	[SerializeField]
	private Vector3 startingDirection;

	[SerializeField]
	private Vector3 rotationDirection;

	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private float orbitRadius;

	[SerializeField]
	private Transform orbiter;

	private Quaternion originalRotation;

	private bool doOrbit;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void ResetOrbit()
	{
	}

	public void StartOrbit()
	{
	}

	public void StopOrbit()
	{
	}

	public Transform GetOrbiter()
	{
		return null;
	}
}
