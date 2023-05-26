using Bolt;
using UnityEngine;

[ExecuteInEditMode]
public class BoltAOI : EntityBehaviour
{
	[SerializeField]
	public float detectRadius;

	[SerializeField]
	public float releaseRadius;

	[SerializeField]
	public int updateRate;

	private void Update()
	{
	}

	public override void SimulateOwner()
	{
	}
}
