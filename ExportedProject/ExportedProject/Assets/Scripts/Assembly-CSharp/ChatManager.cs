using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
	public enum ChannelState
	{
		Disconnected = 0,
		Connecting = 1,
		Connected = 2
	}

	[SerializeField]
	private PopupData chatPopupData;

	[SerializeField]
	private PopupData chatPlayerOptionsPopupData;

	[SerializeField]
	private int newSessionAfterMinutes;

	[SerializeField]
	private int maxHistoryLength;

	[SerializeField]
	private int chatSpamMaxCount;

	[SerializeField]
	private float chatSpamRemoveSeconds;

	[SerializeField]
	private bool useProdChannelsInDevBuilds;

	[SerializeField]
	private bool simulateInitFail;

	[SerializeField]
	private bool simulateConnectFail;

	[SerializeField]
	private PopupData chatErrorPopupData;

	private IChatService chatService;

	private bool isInitialized;

	private Dictionary<string, ChannelState> channelConnections;

	private Dictionary<string, Action<ChatMessage>> channelListeners;

	private bool isPublicChatEnabled;

	private bool didEncounterChatError;

	private string assignedPublicChat;

	private string desiredPublicChat;

	private List<ChatMessage> publicChatHistory;

	private List<ChatMessage> publicChatHistoryChatsOnly;

	private List<ChatChannelGroup> publicChatChannelGroups;

	private Dictionary<Language, ChatChannelGroup> languageToPublicChatChannelGroup;

	private DateTime lastPublicChatDisconnectTime;

	private DateTime fightStartedTime;

	private string lastConnectedPublicChannelName;

	private int idealPublicChannelOccupancy;

	private int maxPublicChannelOccupancy;

	private int chatSpamCounter;

	private float chatSpamTimer;

	private bool isOnChatSpamCooldown;

	private Queue<ChatMessage> chatQueue;

	private HashSet<string> mutedUsers;

	private Regex specialCharacterRegex;

	private Regex openHtmlTagRegex;

	private Regex closeHtmlTagRegex;

	private const string kGlobalSystemChannelName = "sys-global";

	public event Action ChatInitialized
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action PublicChatConnected
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ChatMessage> PublicChatMessageReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	public void Init(string publicId, Action<bool> callback)
	{
	}

	public void ConnectPublicChat(Action<bool> callback = null)
	{
	}

	public void DisconnectPublicChat(Action<bool> callback = null)
	{
	}

	public bool IsConnectedToPublicChat()
	{
		return false;
	}

	public bool IsPublicChatEnabled()
	{
		return false;
	}

	public bool DidEncounterChatError()
	{
		return false;
	}

	public void SendPublicChat(ChatMessage chatMessage, Action<bool> callback = null)
	{
	}

	public void SendActivityMessage(ChatMessage chatMessage)
	{
	}

	public void ChangePublicChatChannel(int channel, Action<bool> callback)
	{
	}

	public void GetPublicChatHistory(int desiredCount, Action<List<ChatMessage>> callback)
	{
	}

	public int GetPublicChatChannelNumber()
	{
		return 0;
	}

	public string GetPublicChatChannelName()
	{
		return null;
	}

	public void ShowPublicChatPopup()
	{
	}

	public void FightStarted()
	{
	}

	public void ShowChatPlayerOptionsPopup(ChatMessage message)
	{
	}

	public void MutePlayer(string publicId)
	{
	}

	public void UnmutePlayer(string publicId)
	{
	}

	public bool IsPlayerMuted(string publicId)
	{
		return false;
	}

	public void ReportPublicChatAbuse(ChatMessage message, List<string> reasons, Action<bool> callback)
	{
	}

	public bool IsOnSpamTimeout()
	{
		return false;
	}

	public bool AddChannelListener(string channelName, Action<ChatMessage> listener)
	{
		return false;
	}

	public bool RemoveChannelListener(string channelName, Action<ChatMessage> listener)
	{
		return false;
	}

	public void MarkSystemChannelsDisconnected()
	{
	}

	public void GetNumberOfChannelsForUser(string publicId, Action<int> callback)
	{
	}

	public void ReconnectSystemChannels()
	{
	}

	private void ConnectChannel(string channelName, Action<bool> callback)
	{
	}

	private void DisconnectChannel(string channelName, Action<bool> callback)
	{
	}

	private string GetUserChannelName()
	{
		return null;
	}

	private bool AreSystemChannelsValid()
	{
		return false;
	}

	private bool IsConnectedToChannel(string channelName)
	{
		return false;
	}

	private ChannelState GetChannelState(string channelName)
	{
		return default(ChannelState);
	}

	private void SendAllQueuedChatMessages()
	{
	}

	private void SendToChannel(ChatMessage chatMessage, Action<bool> callback = null)
	{
	}

	private void SendStatusMessage(string channelName, string message, bool onlyMe = true)
	{
	}

	private void FindBestPublicChatChannelWithFallbacks(ChatChannelGroup channelGroup, Action<bool, string> callback, List<ChatChannelGroup> fallbackChannelGroups = null)
	{
	}

	private void ConnectSystemChat()
	{
	}

	private void OnSystemMessageReceived(ChatMessage message)
	{
	}

	private void OnMessageReceived(ChatMessage message)
	{
	}
}
