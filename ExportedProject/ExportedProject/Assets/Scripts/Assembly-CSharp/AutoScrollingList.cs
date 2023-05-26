using System;
using System.Collections.Generic;
using UnityEngine;

public class AutoScrollingList : MonoBehaviour
{
	[SerializeField]
	private Transform start;

	[SerializeField]
	private Transform end;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float distance;

	private List<GameObject> items;

	private Queue<GameObject> queue;

	private List<GameObject> inTransit;

	private Func<GameObject> addItemDelegate;

	private Action<GameObject> removeItemDelegate;

	private float movementDistance;

	private float maxMovementDistance;

	private void Update()
	{
	}

	public void Init(Transform startTransform, Transform endTransform, float speed, float distance)
	{
	}

	public void Clear()
	{
	}

	public void Prewarm(int steps)
	{
	}

	public void Add(GameObject obj)
	{
	}

	public void UseAddRemoveDelegates(Func<GameObject> addDelegate, Action<GameObject> removeDelegate)
	{
	}

	public float GetSpeed()
	{
		return 0f;
	}

	public void SetSpeed(float newSpeed)
	{
	}

	public void SetDistance(float newDistance)
	{
	}

	public void SetMaxTravelDistance(float maxTravelDistance)
	{
	}

	public void ResetTravelDistance()
	{
	}

	private void MoveItems(float deltaTime)
	{
	}

	private float GetLocalDistanceSquared(Transform fromTrans, Transform toTrans)
	{
		return 0f;
	}
}
