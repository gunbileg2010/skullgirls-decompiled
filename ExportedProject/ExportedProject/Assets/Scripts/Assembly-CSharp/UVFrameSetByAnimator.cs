using System;
using UnityEngine;

public class UVFrameSetByAnimator : MonoBehaviour
{
	[Serializable]
	public class AnimatorDrivenUVAnim
	{
		public string stateName;

		[NonSerialized]
		public int stateNameShortHash;

		public Vector2[] frames;

		public AnimationClip refAnimClip;
	}

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private AnimatorDrivenUVAnim[] anims;

	[SerializeField]
	private string parameterName;

	[SerializeField]
	private int animatorLayer;

	private Renderer targetRenderer;

	private float lastSeenPercent;

	private int parameterId;

	private MaterialPropertyBlock materialPropertyBlock;

	private readonly int _MainTex_ST_ID;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public Vector2 GetCurrentUVOffset(float percent, string stateNameOverride = null)
	{
		return default(Vector2);
	}

	public float GetAnimatorPercent()
	{
		return 0f;
	}

	public bool HasAnimState(string name)
	{
		return false;
	}

	public AnimatorDrivenUVAnim GetAnim(string name)
	{
		return null;
	}

	public AnimatorDrivenUVAnim[] GetAnims()
	{
		return null;
	}

	public int GetAnimationLayer()
	{
		return 0;
	}

	private void SetMaterialUVOffset(Vector2 uvOffset)
	{
	}
}
