using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterScoreComparison : MonoBehaviour
{
	[SerializeField]
	private Text playerFighterScoreText;

	[SerializeField]
	private Text enemyFighterScoreText;

	[SerializeField]
	private RectTransform markerRectTransform;

	[SerializeField]
	private Image gradientImage;

	private EZAnimateFloat changeAnim;

	private void OnEnable()
	{
	}

	public void Clear()
	{
	}

	public void Refresh(List<Character> playerCharacters, List<Character> enemyCharacters, bool immediate = false)
	{
	}

	private void Reset()
	{
	}
}
