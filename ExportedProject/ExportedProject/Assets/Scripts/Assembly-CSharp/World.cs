using System.Collections.Generic;
using UnityEngine;

public class World
{
	public const int kMaxPointLights = 8;

	public const int kMaxDirectionalLights = 4;

	public const float kDefaultFloorShadowFadeDist = -25f;

	private Stage myStage;

	private List<PointLightInfo> pointLights;

	private int usedPointLights;

	private int worldPointLightCount;

	private DirectionalLightInfo[] directionalLights;

	private float floorShadowFadeDistance;

	public World(Stage stage)
	{
	}

	public void Activate()
	{
	}

	public void SetAmbientLight()
	{
	}

	public void ResetPointLights()
	{
	}

	public void AddPointLight(float r, float g, float b, float intensity, float radius, Vector3 position)
	{
	}

	public DirectionalLightInfo[] GetDirectionalLights()
	{
		return null;
	}

	public List<PointLightInfo> GetPointLights()
	{
		return null;
	}

	public float GetFloorShadowFadeDistance()
	{
		return 0f;
	}

	public Stage GetStage()
	{
		return null;
	}

	public uint GetNameHash()
	{
		return 0u;
	}
}
