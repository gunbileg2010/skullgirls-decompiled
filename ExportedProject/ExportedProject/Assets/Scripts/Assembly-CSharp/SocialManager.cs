using System;
using System.Collections.Generic;
using UnityEngine;

public class SocialManager : MonoSingleton<SocialManager>
{
	public Action<int, RectTransform, SocialPopup.ListType, FriendInstance, FriendRequestActionRequest.FriendAction> RemovedFromSocialList;

	public Action<bool, bool> SocialPopupUpdate;

	public Action<RectTransform, bool> GiftClaimed;

	public Action RefreshAddFriends;

	public Action SocialStateUpdatedAction;

	private List<FriendInstance> friends;

	private List<FriendInstance> sentRequests;

	private List<FriendInstance> receivedRequests;

	private List<FriendInstance> usersFound;

	private const int kConfirmPopupLayer = 5;

	private const int kErrorPopupLayer = 7;

	public void ParseServerData(Dictionary<string, object> data)
	{
	}

	public void ParseSearchListData(List<object> friendInstancesDatas)
	{
	}

	public void SocialStateUpdated()
	{
	}

	public bool IsFriendWithPlayer(string publicId)
	{
		return false;
	}

	public bool AnyExistingFriendInstance(string publicId)
	{
		return false;
	}

	public List<FriendInstance> GetFriendsList()
	{
		return null;
	}

	public void SetFriendsList(List<FriendInstance> friends)
	{
	}

	public List<FriendInstance> GetRequestsList()
	{
		return null;
	}

	public void SetRequestsList(List<FriendInstance> receivedRequests)
	{
	}

	public List<FriendInstance> GetSentList()
	{
		return null;
	}

	public List<FriendInstance> GetUsersFoundList()
	{
		return null;
	}

	public void ClearSearchList()
	{
	}

	public void SendFriendRequest(XsProfile profile, Action failureCallback, string lastOnlineText = null)
	{
	}

	public void IgnoreFriendRequest(FriendInstance friendInstance, RectTransform rectTransform, Action failureCallback)
	{
	}

	public void AcceptFriendRequest(FriendInstance friendInstance, RectTransform rectTransform, Action failureCallback)
	{
	}

	public void CancelFriendRequest(FriendInstance friendInstance, RectTransform rectTransform, Action failureCallback)
	{
	}

	public void RemoveFriend(string publicId, Action successCallback, Action failureCallback)
	{
	}

	public void SendSocialGift(FriendInstance friendInstance, Action<bool> successCallback, Action failureCallback)
	{
	}

	public void ClaimSocialGift(FriendInstance friendInstance, RectTransform rectTransform, Action callback, Action failureCallback)
	{
	}

	public void OpenSocialGifts(Action successCallback, Action failureCallback)
	{
	}

	private void HandleResponseError(string message, Action failureCallback = null)
	{
	}

	public SocialManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
