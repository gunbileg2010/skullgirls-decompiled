using System;
using UnityEngine;

public class Gacha3D : MonoBehaviour
{
	public Animation anim;

	public AnimationClip introAnimation;

	public AnimationClip openingAnimation;

	public Action onStartIntro;

	public Action onStopIntro;

	public Action onStartOpening;

	public Action onStopOpening;

	private static readonly Vector3 shadowScale;

	public Transform GetMeshTransform()
	{
		return null;
	}

	public Vector3 GetShadowScale()
	{
		return default(Vector3);
	}

	public void StartIntroAnimation()
	{
	}

	public void StopIntroAnimation()
	{
	}

	public void StartOpeningAnimation()
	{
	}

	public void StopOpeningAnimation()
	{
	}

	private void StartStopAnimation(bool start, string name)
	{
	}
}
