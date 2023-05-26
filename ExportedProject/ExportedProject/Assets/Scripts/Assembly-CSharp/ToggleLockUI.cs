using UnityEngine;
using UnityEngine.UI;

public class ToggleLockUI : MonoBehaviour
{
	[SerializeField]
	private Image lockIcon;

	[SerializeField]
	private Image overlay;

	[SerializeField]
	private Image toggleBG;

	[SerializeField]
	private Sprite unlockedBG;

	[SerializeField]
	private Sprite lockedBG;

	public void SetLockedStatus(bool locked)
	{
	}
}
