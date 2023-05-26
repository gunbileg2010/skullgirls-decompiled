using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FriendListItem : MonoBehaviour
{
	private enum ReasonCantSend
	{
		DailyReset = 0,
		NoGifts = 1,
		NotOpened = 2
	}

	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	private Text onlineDate;

	[SerializeField]
	private GameObject friendsViewParentGO;

	[SerializeField]
	private GameObject requestsViewParentGO;

	[SerializeField]
	private GameObject addFriendsViewParentGO;

	[SerializeField]
	private GameObject separatorViewParentGO;

	[SerializeField]
	private LocalizedUGUIText separatorLeftText;

	[SerializeField]
	private LocalizedUGUIText separatorCenterText;

	[SerializeField]
	private Badge itemBadge;

	[SerializeField]
	private Button sendOrCancelButton;

	[SerializeField]
	private LocalizedUGUIText sendOrCancelText;

	[SerializeField]
	private Button ignoreButton;

	[SerializeField]
	private Button acceptButton;

	[SerializeField]
	private Button sendSocialGiftButton;

	[SerializeField]
	private Button claimSocialGiftButton;

	[SerializeField]
	private Image sendSocialGiftImage;

	[SerializeField]
	private GameObject sendSocialGiftParentGO;

	[SerializeField]
	private Image claimSocialGiftImage;

	[SerializeField]
	private GameObject claimSocialGiftParentGO;

	[SerializeField]
	private GameObject backingGO;

	[SerializeField]
	private Image glowImage;

	[SerializeField]
	private GameObject sendAnimationPrefab;

	[SerializeField]
	private Transform sendSpawn;

	[SerializeField]
	private Transform sendTarget;

	[SerializeField]
	private float sendingAnimLength;

	[SerializeField]
	private ScaleEZSelfContainedAnimator portraitBounce;

	[SerializeField]
	private GameObject sendBannerGO;

	[SerializeField]
	private LocalizedUGUIText sentGiftsCountText;

	[SerializeField]
	private LocalizedUGUIText claimedGiftsCountText;

	private FriendInstance friendInstance;

	private ReasonCantSend cantSendReason;

	private GameObject flyingGift;

	public void PopulateForFriendsList(FriendInstance friendInstance)
	{
	}

	public void PopulateForRequests(FriendInstance friendInstance)
	{
	}

	public void PopulateForAddFriends(FriendInstance friendInstance, string separatorLocKey = null, bool centeredText = false)
	{
	}

	public void StartSendGiftAnimation(bool wasGold)
	{
	}

	public void HideSendGiftButton()
	{
	}

	public void RemoveClaimGiftButton()
	{
	}

	public void ShowStandardGift()
	{
	}

	public void UGUI_ProfileClicked()
	{
	}

	public void UGUI_SendSocialGift()
	{
	}

	public void UGUI_GrayedOutSendPressed()
	{
	}

	public void UGUI_ClaimSocialGift()
	{
	}

	public void UGUI_IgnoreRequest()
	{
	}

	public void UGUI_AcceptRequest()
	{
	}

	public void UGUI_SendOrCancelRequest()
	{
	}

	public FriendInstance GetFriendInstance()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void InternalPopulate(FriendInstance friendInstance)
	{
	}

	private bool ShouldShowSendGift()
	{
		return false;
	}

	private bool ShouldShowClaimGift()
	{
		return false;
	}

	private string GetGoldGiftText(bool sent)
	{
		return null;
	}

	private string GetStandardGiftText(bool sent)
	{
		return null;
	}

	private void ResetButtonInteractivity()
	{
	}

	private void StopPlayingAnim()
	{
	}

	private IEnumerator PlaySendAnimation(Vector3 spawnPosition, Vector3 destinationPosition, Sprite spriteToSet)
	{
		return null;
	}
}
