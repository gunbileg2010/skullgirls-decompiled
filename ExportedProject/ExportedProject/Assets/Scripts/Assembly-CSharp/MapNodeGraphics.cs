using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapNodeGraphics : MonoBehaviour
{
	[SerializeField]
	private List<CharacterPortrait> portraits;

	[SerializeField]
	private List<Image> nodeFrames;

	[SerializeField]
	private Color initialFrameColor;

	[SerializeField]
	private List<GameObject> generalAlerts;

	[SerializeField]
	private Transform playerPickMarker;

	[SerializeField]
	private LocalizedUGUIText teamFighterScoreText;

	[SerializeField]
	private GameObject EffectGO;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Image nodeStateIcon;

	[SerializeField]
	private MatchModifierUI matchModifierUI;

	[SerializeField]
	private Sprite completedSprite;

	[SerializeField]
	private Sprite treasureSprite;

	[SerializeField]
	private Sprite riftBattleDefenseCompletedSprite;

	[SerializeField]
	private Image glow;

	[SerializeField]
	private Color normalGlowColor;

	[SerializeField]
	private Color constraintsGlowColor;

	[SerializeField]
	private Material lockedNodeMaterial;

	[SerializeField]
	private GraphicPulse pulse;

	[SerializeField]
	private GameObject defenseWinsGO;

	[SerializeField]
	private LocalizedUGUIText defenseWinsText;

	[SerializeField]
	private MatchChallengeStatusView matchChallengeStatusView;

	private const int kUnavailableAnimatorParam = 0;

	private const int kAvailableAnimatorParam = 1;

	private const int kCompletedAnimatorParam = 2;

	private Animator nodeEffectAnimator;

	private MapNode mapNode;

	private ButtonSound buttonSound;

	private GameObject indicator;

	private List<FightHistoryServerData> cachedFightHistory;

	private bool cachedFightHistoryIsAttackerPerspective;

	private void Awake()
	{
	}

	public void Init(MapNode mapNode)
	{
	}

	public void ShowDeploymentCharacters(DeploymentServerData deployment)
	{
	}

	public void PopulatePortraitAtIndex(Character character, int index)
	{
	}

	public void ResetDeploymentGraphics(DeploymentServerData deployment)
	{
	}

	public void ResetDeploymentGraphicsAtIndex(DeploymentServerData deployment, int index)
	{
	}

	public void SetDeploymentNodeGraphicsActive()
	{
	}

	public void Refresh()
	{
	}

	public void ShowBossWings(bool show, bool dim)
	{
	}

	public void ShowIndicator(GameObject indicatorPrefab)
	{
	}

	public void CleanupIndicator()
	{
	}

	public Transform GetIconMarker()
	{
		return null;
	}

	public Vector3 GetFocusPosition()
	{
		return default(Vector3);
	}

	public void ShowDefenseWins(MapNodeProgressServerData nodeProgress, List<FightHistoryServerData> fightHistory, bool isAttackerPerspective)
	{
	}

	public void HideDefenseWins()
	{
	}

	public void HideGeneralAlerts()
	{
	}

	public void ShowGeneralAlerts(HashSet<string> variantGuidsToActivateAlertsFor)
	{
	}

	public void UGUI_ButtonPressed()
	{
	}

	public void UGUI_AttemptsButtonPressed()
	{
	}

	public void UGUI_MatchModifierButtonPressed()
	{
	}
}
