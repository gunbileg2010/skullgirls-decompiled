using UnityEngine;
using UnityEngine.UI;

public class FeedingCardHolder : Card
{
	public enum FeedingState
	{
		Locked = 0,
		Available = 1,
		Selected = 2,
		Unavailable = 3
	}

	[SerializeField]
	private Transform anchor;

	[SerializeField]
	private GameObject lockGO;

	[SerializeField]
	private GameObject experienceGO;

	[SerializeField]
	private GameObject checkmarkGO;

	[SerializeField]
	private LocalizedUGUIText baseExpText;

	[SerializeField]
	private GameObject characterBonusGO;

	[SerializeField]
	private LocalizedUGUIText characterBonusText;

	[SerializeField]
	private Image characterIcon;

	[SerializeField]
	private GameObject elementBonusGO;

	[SerializeField]
	private LocalizedUGUIText elementBonusText;

	[SerializeField]
	private ElementAffiliationUI elementalIcon;

	[SerializeField]
	private LocalizedUGUIText shinyFeedingText;

	[SerializeField]
	private UIGradient32 shinyFeedingGradient;

	[SerializeField]
	private LocalizedUGUIText prestigeUpText;

	[SerializeField]
	private UIGradient32 prestigeUpGradient;

	[SerializeField]
	private GameObject prestigeUpIconParent;

	[SerializeField]
	private Image prestigeUpIcon;

	[SerializeField]
	private GameObject prestigeUpIconGlow;

	private CharacterCard card;

	private bool cachedIsEvolution;

	private bool cachedIsMaxedOut;

	private bool cachedPrestigeIncrease;

	private bool cachedPrestigeMax;

	private void OnDisable()
	{
	}

	public void Populate(Character foodCharacter, Character feedingCharacter, bool isEvolution, bool isMaxedOut)
	{
	}

	public override void Clear()
	{
	}

	public void SetFeedingState(FeedingState feedingState, bool shinyCanBeTransfered)
	{
	}

	private void ResetView()
	{
	}
}
