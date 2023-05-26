using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialPopup : SGUGUIPopup
{
	public enum ListType
	{
		FriendsList = 0,
		Requests = 1,
		AddFriends = 2
	}

	[SerializeField]
	protected Image backgroundImage;

	[SerializeField]
	protected RectTransform frameTransform;

	[SerializeField]
	private FriendListItem friendListItemPrefab;

	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private Toggle friendsListToggle;

	[SerializeField]
	private Toggle requestsToggle;

	[SerializeField]
	private Toggle addFriendsToggle;

	[SerializeField]
	private Text friendConnectionsText;

	[SerializeField]
	private Text maxFriendConnectionsText;

	[SerializeField]
	private Badge friendsListBadge;

	[SerializeField]
	private Badge requestsBadge;

	[SerializeField]
	private RecycledScrollList recycledScrollList;

	[SerializeField]
	private RectTransform searchBar;

	[SerializeField]
	private RectTransform viewPort;

	[SerializeField]
	private GameObject openGiftsButtonGO;

	[SerializeField]
	private InputField searchInput;

	[SerializeField]
	private Button searchButton;

	[SerializeField]
	private RectTransform friendsListHeader;

	[SerializeField]
	private LocalizedUGUIText emptySectionText;

	[SerializeField]
	private GameObject friendsListGraphics;

	[SerializeField]
	private GameObject requestsGraphics;

	[SerializeField]
	private GameObject addFriendsGraphics;

	[SerializeField]
	private TopBarCurrencyItem standardGiftDisplay;

	[SerializeField]
	private TopBarCurrencyItem goldGiftDisplay;

	[SerializeField]
	private Badge standardSocialGiftsToOpen;

	[SerializeField]
	private Badge goldSocialGiftsToOpen;

	[SerializeField]
	private Button openGiftsButton;

	[SerializeField]
	private GameObject openSparkPrefab;

	[SerializeField]
	private float claimFlightDuration;

	[SerializeField]
	private float timePerSparkFrame;

	[SerializeField]
	private Vector3 animMaxScale;

	[SerializeField]
	private Vector3 animMinScale;

	[SerializeField]
	private ContextualTutorial friendsListContextualTutorial;

	[SerializeField]
	private ContextualTutorial requestsContextualTutorial;

	[SerializeField]
	private ContextualTutorial addFriendsContextualTutorial;

	[SerializeField]
	private GameObject sortParentGO;

	[SerializeField]
	private GameObject activeSortGlowGO;

	[SerializeField]
	private PopupData sortPopup;

	private bool shouldShowNoSearchResults;

	private bool shouldShowNoSentRequests;

	private ListType context;

	private Stack<FriendListItem> availableFriendListItems;

	private List<FriendListItem> spawnedFriendListItems;

	private float friendsListScrollHeight;

	private float requestsScrollHeight;

	private float addFriendsScrollHeight;

	private const int kSpriteSortOrder = 50;

	private uint kFXImageHash;

	private List<GameObject> sparks;

	private FriendSort friendSort;

	private void Start()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_OpenGifts()
	{
	}

	public void UGUI_SearchFriends()
	{
	}

	public void UGUI_SortPressed()
	{
	}

	private void OnStateChanged(string fromState, string toState)
	{
	}

	private void OnSectionToggleActivated(Toggle toggle)
	{
	}

	private void CheckIfListEmpty()
	{
	}

	private RectTransform OnAddFriendListScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveFriendListScrollItem(RectTransform rectTransform)
	{
	}

	private FriendListItem TakeFriendListItem()
	{
		return null;
	}

	private void RemovedFromSocialList(int updatedCount, RectTransform rectTransform, ListType listType, FriendInstance instance, FriendRequestActionRequest.FriendAction actionType)
	{
	}

	private void SocialPopupUpdate(bool needToRemoveButtons, bool swapSprites)
	{
	}

	private void RefreshAddFriends()
	{
	}

	private void GiftClaimed(RectTransform rectTransform, bool isGold)
	{
	}

	private void SetBadgeParentsActive()
	{
	}

	private int GetSentRequestsCount()
	{
		return 0;
	}

	private int GetSearchResultsCount()
	{
		return 0;
	}

	private void PopuplateSentRequests(FriendListItem item, int index, int searchCount)
	{
	}

	private void OnFriendSortChanged()
	{
	}

	private void StopPlayingClaimSparks()
	{
	}

	private IEnumerator PlayClaimSpark(Vector3 spawnPosition, Vector3 destinationPosition)
	{
		return null;
	}
}
