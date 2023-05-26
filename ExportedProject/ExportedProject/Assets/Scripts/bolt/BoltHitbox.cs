using Bolt;
using UnityEngine;

[Documentation]
public class BoltHitbox : MonoBehaviour
{
	[SerializeField]
	internal BoltHitboxShape _shape;

	[SerializeField]
	internal BoltHitboxType _type;

	[SerializeField]
	internal Vector3 _center;

	[SerializeField]
	internal Vector3 _boxSize;

	[SerializeField]
	internal float _sphereRadius;

	public BoltHitboxShape hitboxShape
	{
		get
		{
			return default(BoltHitboxShape);
		}
		set
		{
		}
	}

	public BoltHitboxType hitboxType
	{
		get
		{
			return default(BoltHitboxType);
		}
		set
		{
		}
	}

	public Vector3 hitboxCenter
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 hitboxBoxSize
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float hitboxSphereRadius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void OnDrawGizmos()
	{
	}

	internal void Draw(Matrix4x4 matrix)
	{
	}

	internal bool OverlapSphere(ref Matrix4x4 matrix, Vector3 center, float radius)
	{
		return false;
	}

	internal bool Raycast(ref Matrix4x4 matrix, Vector3 origin, Vector3 direction, out float distance)
	{
		distance = default(float);
		return false;
	}

	private bool OverlapSphereOnSphere(Vector3 center, float radius)
	{
		return false;
	}

	private bool OverlapSphereOnBox(Vector3 center, float radius)
	{
		return false;
	}

	private bool RaycastSphere(Vector3 o, Vector3 d, out float distance)
	{
		distance = default(float);
		return false;
	}

	private static void ClampVector(ref Vector3 value, ref Vector3 min, ref Vector3 max, out Vector3 result)
	{
		result = default(Vector3);
	}
}
