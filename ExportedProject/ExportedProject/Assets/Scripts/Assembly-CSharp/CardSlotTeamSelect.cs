using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlotTeamSelect : CardSlot
{
	[SerializeField]
	private RectTransform collectionTransform;

	public TeamSelectSlotMode slotMode;

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

	public void RemoveCard(DragCardTeamSelect overrideCard = null)
	{
	}

	protected override void OnDropInternal(PointerEventData eventData)
	{
	}
}
