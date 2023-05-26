using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Spline : MonoBehaviour
{
	public enum SplineType
	{
		Linear = 0,
		Bezier = 1
	}

	public SplineType type;

	public List<Transform> nodes;

	public List<Transform> bezierControlPoints;

	public LineRenderer lineRenderer;

	[SerializeField]
	private Transform target;

	[SerializeField]
	private bool evaluateEvaluatorsInEditor;

	[SerializeField]
	private float t;

	private List<float> nodeTimes;

	private SplineEvaluator[] evaluators;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void AddNode(Transform node, int index)
	{
	}

	public Vector3 NearestPointOnSpline(Vector3 testPoint)
	{
		return default(Vector3);
	}

	public float NearestTOnSpline(Vector3 testPoint)
	{
		return 0f;
	}

	public void PositionTransformAt(Transform transform, float t)
	{
	}

	public Vector3 EvaluatePosition(float t)
	{
		return default(Vector3);
	}

	public Quaternion EvaluateRotation(float t)
	{
		return default(Quaternion);
	}

	public Vector3 EvaluateScale(float t)
	{
		return default(Vector3);
	}

	public void SetT(float newT)
	{
	}

	public void SetTarget(Transform target)
	{
	}

	private void RefreshNodeTimes()
	{
	}

	private void RefreshLineRenderer()
	{
	}

	private Vector3 EvaluateLinearPosition(float t)
	{
		return default(Vector3);
	}

	private Quaternion EvaluateLinearRotation(float t)
	{
		return default(Quaternion);
	}

	private Vector3 EvaluateLinearScale(float t)
	{
		return default(Vector3);
	}

	private Vector3 EvaluateBezierPosition(float t)
	{
		return default(Vector3);
	}
}
