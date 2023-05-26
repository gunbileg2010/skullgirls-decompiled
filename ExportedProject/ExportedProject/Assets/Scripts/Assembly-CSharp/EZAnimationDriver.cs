using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class EZAnimationDriver : MonoBehaviour
{
	[SerializeField]
	protected EZAnimOptions options;

	[SerializeField]
	private bool setToStartStateBeforeDelay;

	[NonSerialized]
	private EZAnimation ezAnim;

	public event Action<EZAnimation> OnStart
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<EZAnimation> OnStop
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayFromStart()
	{
	}

	public void PlayOrResume()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void Stop()
	{
	}

	public void End()
	{
	}

	protected abstract EZAnimation CreateAndStart();

	protected virtual void OnAnimStart(EZAnimation anim)
	{
	}

	protected virtual void OnAnimStop(EZAnimation anim)
	{
	}
}
