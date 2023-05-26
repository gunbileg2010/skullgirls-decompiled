using System.Collections.Generic;
using UnityEngine;

public class MainMapZoneRenderer : MonoBehaviour
{
	private static Dictionary<string, MainMapZoneRenderer> activeMapZones;

	[SerializeField]
	private string zoneName;

	[SerializeField]
	private MainMapZoneRenderer[] childZones;

	private static int active;

	private static int dormant;

	private static int inactive;

	private Color tint;

	private ArtSettings cachedArtSettings;

	private MeshRenderer zoneMeshRenderer;

	private MeshRenderer[] lightMeshRenderers;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static void SetMapZoneStateForKey(string key, ZoneState zoneState)
	{
	}

	public static void SetMapZoneStateForAll(ZoneState zoneState)
	{
	}

	public void RenderInactive()
	{
	}

	public void RenderDormant()
	{
	}

	public void RenderActive()
	{
	}

	private void TriggerAnimators(int trigger)
	{
	}

	private void SetAnimatorTriggers(Animator animator, int trigger)
	{
	}

	private void StopAnimations()
	{
	}

	private void ResetColors()
	{
	}
}
