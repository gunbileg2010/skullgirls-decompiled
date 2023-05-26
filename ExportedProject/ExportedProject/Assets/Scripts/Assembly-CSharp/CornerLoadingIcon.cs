using UnityEngine;

public class CornerLoadingIcon : MonoBehaviour
{
	[SerializeField]
	private GameObject iconGO;

	[SerializeField]
	private LocalizedUGUIText statusText;

	private bool showing;

	private RectTransform iconRectTransform;

	private EZAnimateAnchoredPosition anim;

	private void Awake()
	{
	}

	public void Show(string status, bool immediate)
	{
	}

	public void Hide(bool immediate)
	{
	}

	private void SetStatusText(string status)
	{
	}

	private void OnAnimFinished(EZAnimation ezAnim)
	{
	}
}
