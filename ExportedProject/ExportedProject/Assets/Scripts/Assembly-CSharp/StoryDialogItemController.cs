using UnityEngine;
using UnityEngine.UI;

public class StoryDialogItemController : MonoBehaviour
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private LocalizedUGUIText localizedText;

	[SerializeField]
	private LocalizedUGUIText speakerText;

	[SerializeField]
	private Image speechBubble;

	[SerializeField]
	private AnimationCurve dialogAlphaChange;

	[SerializeField]
	private float preferredWidth;

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private LayoutGroup boxLayoutGroup;

	private float originalAlpha;

	private void Awake()
	{
	}

	public void UpdateState(int idx)
	{
	}

	public void Setup(DialogueItem dialogueItem)
	{
	}
}
