using UnityEngine;
using UnityEngine.UI;

public class ChatWindow : MonoBehaviour
{
	[SerializeField]
	private ChatItem chatItemPrototype;

	[SerializeField]
	private Transform chatContentTransform;

	[SerializeField]
	private int maxChatHistorySize;

	[SerializeField]
	private bool showStatusMessages;

	[SerializeField]
	private ScrollRect chatScrollRect;

	[SerializeField]
	private InputField chatInput;

	[SerializeField]
	private Button sendButton;

	[SerializeField]
	private int minMessageLength;

	[SerializeField]
	private int maxMessageLength;

	[SerializeField]
	private Button pickerButton;

	[SerializeField]
	private LocalizedUGUIText pickerText;

	[SerializeField]
	private InputField pickerInput;

	[SerializeField]
	private CanvasGroup pickerInputCanvasGroup;

	private ChatItem[] chatItems;

	private int nextChatItemIndex;

	private bool needsChatHistory;

	private bool waitingForSend;

	private ChatManager chatManager;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void UGUI_SendMessage()
	{
	}

	public void UGUI_PickChannel()
	{
	}

	public void UGUI_PickChannelInputDismissed()
	{
	}

	private void AddChatMessageToHistory(ChatMessage message)
	{
	}

	private void OnPublicChatConnected()
	{
	}

	private void OnChatMessageReceived(ChatMessage message)
	{
	}

	private void ForceRefreshChatContentLayout()
	{
	}
}
