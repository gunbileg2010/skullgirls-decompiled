using System;
using UnityEngine;

[Serializable]
public class PointLightInfo
{
	[HideInInspector]
	public bool enabled;

	public Vector3 color;

	public Vector3 position;

	public float radius;
}
