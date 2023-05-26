using UnityEngine;
using UnityEngine.UI;

public class DebugFighterStatsUI : MonoBehaviour
{
	[SerializeField]
	private Text lifebarValueText;

	[SerializeField]
	private Text barrierLifeText;

	[SerializeField]
	private Text aiStatusText;

	private Actor actor;

	private int prevLifebar;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetFighter(Actor actor)
	{
	}

	public void SetAIStatus(string status)
	{
	}
}
