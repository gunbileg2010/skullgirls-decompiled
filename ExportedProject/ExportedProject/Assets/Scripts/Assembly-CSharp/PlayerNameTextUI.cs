using UnityEngine;
using UnityEngine.UI;

public class PlayerNameTextUI : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText textField;

	[SerializeField]
	private UIGradient32 textGradient;

	[SerializeField]
	private bool usePlayerSummaryGradient;

	[SerializeField]
	private bool useOverrideGradient;

	[SerializeField]
	private Gradient overrideGradient;

	[SerializeField]
	private Image developerIcon;

	[SerializeField]
	private UIGradient32 iconGradient;

	public void Populate(string playerName = null, bool isSeedTeam = false, bool isDeveloper = false, bool inFight = false)
	{
	}
}
