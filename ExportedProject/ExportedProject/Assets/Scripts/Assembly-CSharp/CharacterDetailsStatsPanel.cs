using System.Collections.Generic;
using UnityEngine;

public class CharacterDetailsStatsPanel : MonoBehaviour
{
	[SerializeField]
	private Transform baseStatsTable;

	[SerializeField]
	private Transform statsViewTable;

	[SerializeField]
	private Color increasedStatColor;

	[SerializeField]
	private Color unmodifiedStatColor;

	private List<CharacterStatView> statViews;

	public void Populate(Character character)
	{
	}

	private List<CharacterStatView> GetStatViews()
	{
		return null;
	}
}
