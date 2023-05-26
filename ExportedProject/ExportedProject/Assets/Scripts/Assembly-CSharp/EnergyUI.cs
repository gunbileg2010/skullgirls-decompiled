using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyUI : MonoBehaviour
{
	[SerializeField]
	private GameObject energyParentGO;

	[SerializeField]
	private GameObject energyItemGO;

	[SerializeField]
	private Text energyText;

	[SerializeField]
	private Sprite standardEnergyBoltOverride;

	[SerializeField]
	private Sprite rankedEnergyBoltOverride;

	private const int kMaxIconCount = 6;

	private List<GameObject> energyGOs;

	public void Show(int energyAmount)
	{
	}

	public void Hide()
	{
	}

	private void SetupEnergyIcon(GameObject energyImageGO)
	{
	}
}
