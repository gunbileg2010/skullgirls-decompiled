using UnityEngine;

public class TalkingHeadStaticImage : MonoBehaviour
{
	[SerializeField]
	private TalkingHead talkingHead;

	[SerializeField]
	private string emote;

	private AlphaMaskImage image;

	private TalkingHead activeTalkingHead;

	private string activeTalkingHeadEmoteName;

	private Vector2 offset;

	private void OnEnable()
	{
	}

	public void SetTalkingHead(TalkingHead passedTalkingHead, string emoteName)
	{
	}

	public void AddOffset(Vector2 addOffset)
	{
	}

	public void Clear()
	{
	}
}
