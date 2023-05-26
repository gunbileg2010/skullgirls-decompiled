using UnityEngine;
using UnityEngine.UI;

public class LifebarBit : MonoBehaviour
{
	public static LifebarBit lifebarBitPrefab;

	[SerializeField]
	private Image image;

	private static ObjectPool<LifebarBit> lifebarBitPool;

	private Vector3 velocity;

	private Vector3 acceleration;

	private float zDeltaRotation;

	private float alphaOutThreshold;

	private float timeToLive;

	private float timeAlive;

	private Color originalColor;

	private RectTransform cachedTransform;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static LifebarBit TakeFromPool()
	{
		return null;
	}

	public static void ReturnToPool(LifebarBit lifebarBit)
	{
	}

	public void Init(Vector3 accel, Vector3 vel, float width, float zDeltaRot, float ttl = 0.6f, float alphaOutTime = 0.4f)
	{
	}

	private static LifebarBit CreateNewLifebarBit()
	{
		return null;
	}
}
