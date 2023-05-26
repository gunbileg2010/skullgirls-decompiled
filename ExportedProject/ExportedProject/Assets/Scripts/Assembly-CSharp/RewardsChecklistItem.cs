using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class RewardsChecklistItem : MonoBehaviour
{
	[SerializeField]
	protected LocalizedUGUIText headerText;

	[SerializeField]
	protected Image checkmark;

	public abstract void Populate(string header, bool completed, List<Loot> loots);

	public abstract void Clear();
}
