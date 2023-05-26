using UnityEngine;

public class SetNewMeridianZoneStatesSequentialAction : SequentialAction
{
	[SerializeField]
	private bool setBastetsDen;

	[SerializeField]
	private ZoneState bastetsDenZoneState;

	[SerializeField]
	private bool setCanopolis;

	[SerializeField]
	private ZoneState canopolisZoneState;

	[SerializeField]
	private bool setCathedral;

	[SerializeField]
	private ZoneState cathedralZoneState;

	[SerializeField]
	private bool setInnsmouth;

	[SerializeField]
	private ZoneState innsmouthZoneState;

	[SerializeField]
	private bool setLab8;

	[SerializeField]
	private ZoneState lab8ZoneState;

	[SerializeField]
	private bool setMaplecrest;

	[SerializeField]
	private ZoneState maplecrestZoneState;

	[SerializeField]
	private bool setMediciTower;

	[SerializeField]
	private ZoneState mediciTowerZoneState;

	[SerializeField]
	private bool setRiverKing;

	[SerializeField]
	private ZoneState riverKingZoneState;

	[SerializeField]
	private bool setRooftops;

	[SerializeField]
	private ZoneState rooftopsZoneState;

	[SerializeField]
	private bool setStadium;

	[SerializeField]
	private ZoneState stadiumZoneState;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
