using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarUI : MonoBehaviour
{
	[SerializeField]
	private Image energySegmentPrototype;

	[SerializeField]
	private Vector2 minMaxRechargeAlpha;

	[SerializeField]
	private float rechargeAlphaSpeed;

	[SerializeField]
	private Vector2 tooltipPivot;

	private List<Image> energySegments;

	private Energy energy;

	private bool riftBattleMode;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Populate(Character character, EnergyType energyType)
	{
	}

	public void PopulateBattle(Character character, BattleInstanceServerData battleInstance)
	{
	}

	public void UGUI_ShowEnergyTooltip()
	{
	}
}
