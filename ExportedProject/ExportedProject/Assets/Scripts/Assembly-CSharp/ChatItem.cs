using UnityEngine;

public class ChatItem : MonoBehaviour
{
	[SerializeField]
	private TextWithHref messageText;

	[SerializeField]
	private int maxChatItemLength;

	private ChatMessage chatMessage;

	private string contextTag;

	private string contextEndTag;

	public void Populate(ChatMessage message)
	{
	}

	public void UGUI_ChatContextPressed()
	{
	}

	private Color GetHandleColor(ChatMessage message)
	{
		return default(Color);
	}

	private string GetMessageFromActivityMessage(ChatMessage chatMessage)
	{
		return null;
	}

	private string GetCharacterBaseNameWithShiny(ChatMessage message, string colorTag, string colorEndTag, Element element)
	{
		return null;
	}
}
