using System.Collections.Generic;
using UnityEngine;

public class MatchChallengeStatusView : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> matchChallengeElements;

	[SerializeField]
	private Sprite incompleteChallengeSprite;

	[SerializeField]
	private Sprite completeChallengeSprite;

	private SGMatch match;

	public void Populate(SGMatch match)
	{
	}

	public void UGUI_ChallengeViewPressed()
	{
	}
}
