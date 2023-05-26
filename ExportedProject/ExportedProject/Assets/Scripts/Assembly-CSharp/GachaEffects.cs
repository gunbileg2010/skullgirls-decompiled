using System;
using System.Collections;
using UnityEngine;

public class GachaEffects : MonoBehaviour
{
	[Serializable]
	private class EffectParams
	{
		public float overallShakeMultiplier;

		public AnimationCurve shakeCurve;

		public float shakePositionMultiplier;

		public float shakeAngleMultiplier;

		public float shakeSpeed;

		public Vector3 shakeAngleMovementRange;
	}

	[SerializeField]
	private EffectParams initialParams;

	[SerializeField]
	private EffectParams openingParams;

	private EffectParams fromParams;

	private EffectParams toParams;

	private float t;

	private Transform shakeTransform;

	private Transform rotateTransform;

	private Vector3 initialShakePosition;

	private Quaternion initialShakeRotation;

	private Quaternion initialRotation;

	private Coroutine shakingCoroutine;

	private Coroutine shakeCurveCoroutine;

	private float currentBehaviorStrength;

	private Coroutine rotationCoroutine;

	private EZAnimateFloat rotationSpeedInterpAnim;

	private float rotationSpeed;

	private float interpolationShakeForce => 0f;

	private float interpolationShakeSpeed => 0f;

	private float shakeForceMultiplier => 0f;

	private float angleShakeForceMultiplier => 0f;

	private Vector3 restrictions => default(Vector3);

	private float GetCurveVal(float time)
	{
		return 0f;
	}

	public void SetTransforms(Transform rotateTransform, Transform shakeTransform)
	{
	}

	public void Restart()
	{
	}

	public void StartShaking()
	{
	}

	public void StartShaking(bool reset)
	{
	}

	public void StopShaking()
	{
	}

	public bool IsShaking()
	{
		return false;
	}

	public void StartRotating(float initialRotationSpeed)
	{
	}

	public void StopRotating()
	{
	}

	public void ChangeRotationSpeed(float newRotationSpeed, float interpDuration = 0f)
	{
	}

	public void TransitionToOpening(float duration = 0.2f)
	{
	}

	public void SetT(float t)
	{
	}

	private IEnumerator AnimateShake()
	{
		return null;
	}

	private float GetRandomAngle(float baseAngle)
	{
		return 0f;
	}

	private Vector3 GetRandomTarget()
	{
		return default(Vector3);
	}

	private IEnumerator EvaluateShakeCurve()
	{
		return null;
	}

	private IEnumerator AnimateRotation()
	{
		return null;
	}
}
