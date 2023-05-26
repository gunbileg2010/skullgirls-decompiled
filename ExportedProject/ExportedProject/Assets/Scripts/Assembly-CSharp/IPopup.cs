using System;

public interface IPopup
{
	event Action<IPopup> ShowEvent;

	event Action<IPopup> HideEvent;

	void Show();

	void Hide();

	void Back();

	void SetData(PopupData data);

	PopupData GetData();

	void SetQueueNumber(int queueNumber);

	int GetQueueNumber();

	int GetSortingOrder();

	void SetSortingOrder(int orderInLayer);

	bool IsActive();
}
