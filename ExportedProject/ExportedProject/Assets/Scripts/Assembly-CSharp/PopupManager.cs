using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
	[SerializeField]
	private bool debug;

	public const int kDefaultSortingOrder = 5;

	private Dictionary<int, LinkedList<PopupData>> popupQueues;

	private List<IPopup> activePopups;

	private int currentQueueNumber;

	private List<Canvas> bubbledUpCanvases;

	public void ShowPopup(PopupData popupData)
	{
	}

	public void QueuePopup(PopupData popupData)
	{
	}

	public void InsertPopup(PopupData popupData, int position)
	{
	}

	public void ClearPopupQueue(int queueNumber = 0)
	{
	}

	public void HideAllAndClearQueues()
	{
	}

	public int GetPopupQueueLength(int queueNumber = 0)
	{
		return 0;
	}

	public IPopup GetCurrentPopup()
	{
		return null;
	}

	public void BubbleUpCanvasAndAddToPopupStack(Canvas canvas)
	{
	}

	public void RemoveCanvasFromPopupStack(Canvas canvas)
	{
	}

	private void ShowPopupInternal(PopupData popupData, int queueNumber, int? orderInLayer = null)
	{
	}

	private void OnPopupHide(IPopup popup)
	{
	}

	private int GetCurrentSortingOrder()
	{
		return 0;
	}
}
