using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EZAnimator : MonoBehaviour
{
	private static EZAnimator s_Instance;

	private static bool hasQuit;

	private Dictionary<Type, EZLinkedList<EZAnimation>> pool;

	private EZLinkedList<EZAnimation> animations;

	private EZLinkedListIterator<EZAnimation> animsIt;

	private float lastTime;

	private float currentTime;

	public static EZAnimator instance => null;

	public static bool Exists()
	{
		return false;
	}

	public void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Awake()
	{
	}

	private void OnActiveSceneChanged(Scene from, Scene to)
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void Update()
	{
	}

	public T GetAnimation<T>() where T : EZAnimation, new()
	{
		return null;
	}

	public void AddAnimation(EZAnimation a)
	{
	}

	public void EndAnimation(EZAnimation a)
	{
	}

	public void StopAnimation(EZAnimation a)
	{
	}

	public void StopAnimation(EZAnimation a, bool end)
	{
	}

	public void StopObjectAnimations(object obj)
	{
	}

	public void StopObjectAnimationsOfType<T>(object obj, bool end)
	{
	}

	public void EndObjectAnimations(object obj)
	{
	}

	public bool IsObjectAnimated(object go)
	{
		return false;
	}

	public void EndAll()
	{
	}

	public void StopAll()
	{
	}

	public void PauseAll()
	{
	}

	public void UnpauseAll()
	{
	}

	private void ReturnAnimToPool(EZAnimation anim)
	{
	}

	private void StopObjectAnimations(object obj, bool end)
	{
	}
}
