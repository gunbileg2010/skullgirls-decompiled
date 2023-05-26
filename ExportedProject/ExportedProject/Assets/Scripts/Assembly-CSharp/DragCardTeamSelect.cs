using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragCardTeamSelect : DragCard
{
	private const float kDecideToScrollThreshold = 1f;

	private const float kDecideToDragThreshold = 2.5f;

	private ScrollRect scrollRect;

	private HorizontalOrVerticalLayoutGroup layoutGroup;

	private Card card;

	private bool decidedOnAction;

	private bool passToScrollRect;

	private bool isInTeamArea;

	private bool swappingEnabled;

	public event Action TeamUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	public void SetInTeamArea(bool inTeamArea)
	{
	}

	public bool GetInTeamArea()
	{
		return false;
	}

	public void SetSwappingEnabled(bool isEnabled)
	{
	}

	public Card GetCard()
	{
		return null;
	}

	public CharacterCard GetCharacterCard()
	{
		return null;
	}

	public CollectibleNodeModifierCard GetCollectibleNodeModifierCard()
	{
		return null;
	}

	public TeamSelectSlotMode GetExpectedSlotMode()
	{
		return default(TeamSelectSlotMode);
	}

	protected override void OnBeginDragInternal(PointerEventData eventData)
	{
	}

	protected override void OnDragInternal(PointerEventData eventData)
	{
	}

	protected override void OnEndDragInternal(PointerEventData eventData)
	{
	}

	protected override void OnDropInternal(PointerEventData eventData)
	{
	}

	private void SwapTeamAreaCards(DragCardTeamSelect card1, DragCardTeamSelect card2)
	{
	}

	private void SwapTeamAreaCardWithNonTeamAreaCard(DragCardTeamSelect teamAreaCard, DragCardTeamSelect nonTeamAreaCard)
	{
	}

	private void RemoveTeamAreaCard(DragCardTeamSelect teamAreaCard)
	{
	}
}
