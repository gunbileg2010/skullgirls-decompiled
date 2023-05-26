using System.Collections;
using UnityEngine;

public class MatchSelectScreen : MonoBehaviour
{
	public static Stage selectedStage;

	[SerializeField]
	private Fight[] matchSettings;

	[SerializeField]
	private GameObject itemPrefab;

	[SerializeField]
	private RectTransform contentArea;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UGUI_MatchPressed(Fight settings)
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}
}
