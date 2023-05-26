using System;
using UnityEngine;

[Serializable]
public class GachaShardProgressUI
{
	public GachaData gachaData;

	public GameObject gachaShardsGO;

	public ProgressBarUI progressBar;

	public AnchoredPositionEZSelfContainedAnimator earnedUpAnim;

	public CanvasGroup earnedTextCanvasCroup;
}
