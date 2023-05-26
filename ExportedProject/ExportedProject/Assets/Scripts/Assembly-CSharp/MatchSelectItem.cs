using UnityEngine;

public class MatchSelectItem : MonoBehaviour
{
	[SerializeField]
	private Transform[] fullSlotMarkers;

	[SerializeField]
	private Transform[] assistSlotmarkers;

	[SerializeField]
	private GameObject cardPrefab;

	private void Awake()
	{
	}

	public void Populate(Fight fight)
	{
	}
}
