using UnityEngine;

public class ShowContextualPopup : MonoBehaviour
{
	[SerializeField]
	private string contextStringToShow;

	[SerializeField]
	private Transform contextPopupParent;

	[SerializeField]
	private bool centerOnThisTransform;

	[SerializeField]
	private int howLongToShowPopup;

	[SerializeField]
	private bool ensureNormalScale;

	public void UGUI_ShowPopup()
	{
	}
}
