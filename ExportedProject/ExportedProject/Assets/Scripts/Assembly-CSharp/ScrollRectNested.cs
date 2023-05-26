using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollRectNested : ScrollRect
{
	private ScrollRect parentScrollRect;

	private bool routeToParent;

	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	private ScrollRect GetParentScrollRect()
	{
		return null;
	}
}
