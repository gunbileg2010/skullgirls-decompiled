using UnityEngine;
using UnityEngine.UI;

public class BattleRankBadge : MonoBehaviour
{
	[SerializeField]
	private Image playerRankBanner;

	[SerializeField]
	private Shadow playerRankTextShadow;

	[SerializeField]
	private LocalizedUGUIText playerRankText;

	[SerializeField]
	private RiftTier debugPlayerRank;

	public void DebugPreview()
	{
	}

	public void Populate(RiftTier playerRank)
	{
	}
}
