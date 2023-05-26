using System;
using System.Collections;
using UnityEngine;

public class UVFramesAnimation : MonoBehaviour
{
	[Serializable]
	public class FrameAnim
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private float frameTime;

		[SerializeField]
		private bool loop;

		[SerializeField]
		private Vector2[] uvOffsetFrames;

		public Vector2 GetUVOffsetForFrame(int index)
		{
			return default(Vector2);
		}

		public int GetFrameCount()
		{
			return 0;
		}

		public bool GetShouldLoop()
		{
			return false;
		}

		public float GetFrameTime()
		{
			return 0f;
		}

		public string GetName()
		{
			return null;
		}
	}

	[SerializeField]
	private string initialAnim;

	[SerializeField]
	private string fallbackAnim;

	[SerializeField]
	private Vector2 defaultUVOffset;

	[SerializeField]
	private FrameAnim[] frameAnims;

	private readonly int _MainTex_ST_ID;

	private Renderer targetRenderer;

	private MaterialPropertyBlock materialPropertyBlock;

	private Coroutine animCoroutine;

	private FrameAnim currentAnim;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void PlayAnimation(string animName, bool force = false)
	{
	}

	public void StopAnimation()
	{
	}

	public FrameAnim[] GetAnims()
	{
		return null;
	}

	public bool HasAnimWithName(string name)
	{
		return false;
	}

	public FrameAnim GetAnimWithName(string name)
	{
		return null;
	}

	private IEnumerator DoPlayAnimation(FrameAnim anim)
	{
		return null;
	}

	private void SetUVOffset(Vector2 uvOffset)
	{
	}
}
