using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpriteFrameAnimation : MonoBehaviour
{
	[Serializable]
	public class Anim
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private float frameTime;

		[SerializeField]
		private bool loop;

		[SerializeField]
		private Sprite[] sprites;

		[SerializeField]
		private bool useDynamicResources;

		[SerializeField]
		private DynamicResource[] dynamicSprites;

		public void PrepareDynamics()
		{
		}

		public void TakeDynamics()
		{
		}

		public void ReturnDynamics()
		{
		}

		public Sprite GetSprite(int index)
		{
			return null;
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

	public Sprite defaultSprite;

	public DynamicResource defaultDynamicResourceSprite;

	public string initialAnim;

	public Anim[] frameAnims;

	private SpriteRenderer spriteRenderer;

	private Image image;

	private Coroutine animCoroutine;

	private Anim currentAnim;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PlayAnimation(string animName, bool force = false)
	{
	}

	public void StopAnimation()
	{
	}

	private IEnumerator DoPlayAnimation(Anim anim)
	{
		return null;
	}

	private void SetSprite(Sprite sprite)
	{
	}
}
