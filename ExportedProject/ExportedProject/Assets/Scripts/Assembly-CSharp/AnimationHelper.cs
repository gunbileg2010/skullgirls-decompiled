using UnityEngine;

public class AnimationHelper : MonoBehaviour
{
	[SerializeField]
	private Animation anim;

	[SerializeField]
	private AnimationClip resetClip;

	[SerializeField]
	private float resetClipNormalizedTime;

	[Space]
	[SerializeField]
	private bool resetOnEnable;

	[SerializeField]
	private bool rewindOnStop;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void DoReset()
	{
	}

	public void Play(float speed = 1f)
	{
	}

	public void Play(AnimationClip clip, float speed = 1f)
	{
	}

	public void Play(string clipName, float speed = 1f)
	{
	}

	public void PlayReverse(float speed = 1f)
	{
	}

	public void PlayReverse(AnimationClip clip, float speed = 1f)
	{
	}

	public void PlayReverse(string clipName, float speed = 1f)
	{
	}

	public void Pause()
	{
	}

	public void Pause(AnimationClip clip)
	{
	}

	public void Pause(string clipName)
	{
	}

	public void Resume()
	{
	}

	public void Resume(AnimationClip clip)
	{
	}

	public void Resume(string clipName)
	{
	}

	public void Stop(AnimationClip clip)
	{
	}

	public void Stop(string clipName)
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public bool IsPlayingClip(AnimationClip clip)
	{
		return false;
	}

	public bool IsPlayingClip(string clipName)
	{
		return false;
	}

	public Animation GetAnimation()
	{
		return null;
	}
}
