using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityMap : MonoSingleton<CityMap>
{
	[SerializeField]
	private float autoScrollSpeed;

	[SerializeField]
	private EZAnimation.EASING_TYPE autoScrollInterpolator;

	[SerializeField]
	private Transform visualAnchorTransform;

	[SerializeField]
	private CityMapZone bastetsDenMapZone;

	[SerializeField]
	private CityMapZone canopolisMapZone;

	[SerializeField]
	private CityMapZone cathedralMapZone;

	[SerializeField]
	private CityMapZone innsmouthMapZone;

	[SerializeField]
	private CityMapZone lab8MapZone;

	[SerializeField]
	private CityMapZone maplecrestMapZone;

	[SerializeField]
	private CityMapZone mediciTowerMapZone;

	[SerializeField]
	private CityMapZone riverKingMapZone;

	[SerializeField]
	private CityMapZone rooftopsMapZone;

	[SerializeField]
	private CityMapZone rooftopsMapZoneNight;

	[SerializeField]
	private CityMapZone stadiumMapZone;

	[SerializeField]
	private CityMapZone bridgeMapZone;

	[SerializeField]
	private CityMapZone downtownMapZone;

	[SerializeField]
	private CityMapZone noMansLandZone;

	private ScrollRect mapScrollRect;

	private List<CityMapZone> _mapZones;

	private EZAnimation scrollingAnimation;

	private List<CityMapZone> MapZones => null;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public float GetMapScrollPosition()
	{
		return 0f;
	}

	public void SetMapScrollPosition(float normalizedScrollPos)
	{
	}

	public void ScrollToZone(Zone targetZone, Action onFinishCallback = null)
	{
	}

	public void ScrollToZone(CityMapZone targetZone, Action onFinishCallback = null)
	{
	}

	public void ScrollTo(float endPos, Action onFinishCallback = null)
	{
	}

	public void ScrollTo(float endPos, float duration, Action onFinishCallback = null)
	{
	}

	public void ScrollFromTo(float startPos, float endPos, Action onFinishCallback = null)
	{
	}

	public void ScrollFromTo(float startPos, float endPos, float duration, Action onFinishCallback = null)
	{
	}

	public void StopScrolling()
	{
	}

	public void SetInnsmouthState(ZoneState zoneState)
	{
	}

	public void SetCathedralState(ZoneState zoneState)
	{
	}

	public void SetBastetsDenState(ZoneState zoneState)
	{
	}

	public void SetLab8State(ZoneState zoneState)
	{
	}

	public void SetCanopolisState(ZoneState zoneState)
	{
	}

	public void SetMaplecrestState(ZoneState zoneState)
	{
	}

	public void SetMediciTowerState(ZoneState zoneState)
	{
	}

	public void SetRiverKingState(ZoneState zoneState)
	{
	}

	public void SetRooftopsState(ZoneState zoneState)
	{
	}

	public void SetRooftopsNightState(ZoneState zoneState)
	{
	}

	public void SetStadiumState(ZoneState zoneState)
	{
	}

	public void SetBridgeState(ZoneState zoneState)
	{
	}

	public void SetStreetsState(ZoneState zoneState)
	{
	}

	public void SetNoMansState(ZoneState zoneState)
	{
	}

	public void SetAllDormant(bool forceVisualRefresh = false)
	{
	}

	public List<CityMapZone> GetCityMapZones()
	{
		return null;
	}

	public CityMapZone GetCityMapZone(Zone zone)
	{
		return null;
	}

	public Vector3 GetCityMapAnchorPosition()
	{
		return default(Vector3);
	}

	public CityMap()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
