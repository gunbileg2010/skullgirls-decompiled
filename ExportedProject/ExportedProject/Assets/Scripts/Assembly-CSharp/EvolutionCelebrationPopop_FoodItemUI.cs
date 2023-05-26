using System.Collections;
using UnityEngine;

public class EvolutionCelebrationPopop_FoodItemUI : MonoBehaviour
{
	[SerializeField]
	private Animation anim;

	[SerializeField]
	private AnimationClip idleAnim;

	[SerializeField]
	private AnimationClip feedAnim;

	[SerializeField]
	private AudioClip gulpSound;

	public float gulpRequestAmount;

	private Coroutine coroutineRef;

	public bool isPlaying => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Play(float delay)
	{
	}

	public void PlayEatSound()
	{
	}

	private IEnumerator PlayDelayed(float delay)
	{
		return null;
	}
}
