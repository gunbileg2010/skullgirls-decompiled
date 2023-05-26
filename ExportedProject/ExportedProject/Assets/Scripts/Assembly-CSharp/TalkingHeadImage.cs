using UnityEngine;

public class TalkingHeadImage : MonoBehaviour
{
	[SerializeField]
	private AlphaMaskImage image;

	public RectTransform anchorParent;

	private RectTransform _myRectTransform;

	private RectTransform _imageRectTransform;

	public RectTransform rectTransform => null;

	private RectTransform imageRectTransform => null;

	public void SetTalkingHead(TalkingHead talkingHead, string emoteName)
	{
	}

	public void SetImage(Sprite sprite, Texture2D mask, float scale = 1f, float alpha = 1f, Vector2? customPivot = null)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public float GetAlpha()
	{
		return 0f;
	}

	public void ClearImage()
	{
	}

	public bool IsShowingTalkingHead()
	{
		return false;
	}

	private void UpdateImagePositioning(Sprite sprite, float scale, Vector2? customPivot = null)
	{
	}
}
