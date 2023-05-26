using System;
using UnityEngine;

public class SequentialAction : MonoBehaviour
{
	protected Action onComplete;

	public virtual void Execute(Action onComplete)
	{
	}

	public void Stop()
	{
	}

	public override string ToString()
	{
		return null;
	}

	protected virtual void ExecuteAction()
	{
	}

	protected virtual void FinishAction()
	{
	}
}
