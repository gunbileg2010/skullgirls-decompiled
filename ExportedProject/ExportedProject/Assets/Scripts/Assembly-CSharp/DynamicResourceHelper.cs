using System;
using UnityEngine;

public class DynamicResourceHelper : MonoBehaviour
{
	[SerializeField]
	private DynamicResource dynamicResource;

	[SerializeField]
	private Component component;

	[NonSerialized]
	private bool taken;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateResource(DynamicResource newResource)
	{
	}

	private bool LoadAndApply()
	{
		return false;
	}
}
