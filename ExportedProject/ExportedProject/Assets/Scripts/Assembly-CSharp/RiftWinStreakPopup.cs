using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiftWinStreakPopup : SGUGUIPopup
{
	[SerializeField]
	private RiftWinStreakPopupLine riftWinLinePrefab;

	[SerializeField]
	private Transform riftWinLineParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private LocalizedUGUIText footer;

	private List<RiftWinStreakPopupLine> instantiatedLines;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}
}
