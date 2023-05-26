using System.Collections.Generic;
using UnityEngine;

public class GameTipsManager : MonoBehaviour
{
	[SerializeField]
	private List<GameTipData> tips;

	private int tipIndex;

	private void Start()
	{
	}

	public GameTipData GetNextTip()
	{
		return null;
	}

	private void RandomizeTips()
	{
	}
}
