using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlot : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	[SerializeField]
	protected int index;

	public void SetIndex(int newIndex)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public void OnDrop(PointerEventData eventData)
	{
	}

	protected virtual void OnDropInternal(PointerEventData eventData)
	{
	}
}
