using System;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeItem : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private LocalizedUGUIText lockedUIDescriptionText;

	[SerializeField]
	private LocalizedUGUIText lockedUICriteriaText;

	[SerializeField]
	private Text rewardsText;

	[SerializeField]
	private GameObject claimButton;

	[SerializeField]
	private GameObject goNowButton;

	[SerializeField]
	private GameObject lockedUIParent;

	[SerializeField]
	private GameObject egretIconGlow;

	[SerializeField]
	private Image completedImage;

	private Challenge myChallenge;

	private Action<string> claimCallback;

	private Action<ChallengeRedirectDestination> goNowCallback;

	private Action<Vector3, int> claimChallengeSpecialEffectCallback;

	public void Populate(Challenge challenge)
	{
	}

	public void DoSpecialClaimEffect()
	{
	}

	public string GetChallengeGuid()
	{
		return null;
	}

	public bool IsChallengeItemClaimable()
	{
		return false;
	}

	public void SetClaimClickCallback(Action<string> callback)
	{
	}

	public void SetClaimChallengeSpecialEffectCallback(Action<Vector3, int> callback)
	{
	}

	public void SetGoNowClickCallback(Action<ChallengeRedirectDestination> callback)
	{
	}

	public void UGUI_ClaimButtonClicked()
	{
	}

	public void UGUI_GoNowButtonClicked()
	{
	}
}
