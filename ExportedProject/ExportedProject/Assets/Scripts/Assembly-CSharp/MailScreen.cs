using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailScreen : MonoBehaviour
{
	[SerializeField]
	private GameObject mailListGO;

	[SerializeField]
	private GameObject mailViewGO;

	[SerializeField]
	private GameObject bottomBar;

	[SerializeField]
	private ScrollRect mailListScrollRect;

	[SerializeField]
	private MailListItem mailListItemPrefab;

	[SerializeField]
	private Toggle unreadToggle;

	[SerializeField]
	private LoadingView loadingView;

	[SerializeField]
	private MailView mailView;

	[SerializeField]
	private Button selectAllButton;

	[SerializeField]
	private Button deselectAllButton;

	[SerializeField]
	private Button markAsReadButton;

	[SerializeField]
	private Button claimRewardsButton;

	[SerializeField]
	private Button deleteButton;

	private List<MailListItem> mailListItems;

	private bool showReadMail;

	private bool gotServerError;

	private bool zeroMailsReceived;

	private int mailPage;

	private int mailPageSize;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ShowMailList(MailServerData fromMailServerData = null, bool forceRefreshAll = false)
	{
	}

	public void DeleteMail(MailServerData mail)
	{
	}

	public void SelectionChanged()
	{
	}

	public void UGUI_ToggleUnread(bool isOn)
	{
	}

	public void UGUI_ToggleRead(bool isOn)
	{
	}

	public void UGUI_SelectAll()
	{
	}

	public void UGUI_DeselectAll()
	{
	}

	public void UGUI_MarkSelectedAsRead()
	{
	}

	public void UGUI_ClaimRewardsFromSelected()
	{
	}

	public void UGUI_DeleteSelected()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void RefreshMailsFromServer()
	{
	}

	private void GetMails(int page, int count, Action<bool, List<MailServerData>> callback)
	{
	}

	private void RefreshMailListView()
	{
	}

	private void OnMailListItemClicked(MailListItem mailListItem)
	{
	}

	private IEnumerator MultiDeleteMailCoroutine(List<MailServerData> mailToDelete)
	{
		return null;
	}
}
