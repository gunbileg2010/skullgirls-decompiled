using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperAbilityInfoPopup : MonoBehaviour
{
	[Serializable]
	private class SuperAbilityFeatureUI
	{
		public LocalizedUGUIText title;

		public LocalizedUGUIText description;

		public LocalizedUGUIText levelText;

		public GameObject lockGO;

		public GameObject selectedGO;

		public AdvancedButton upgradeButton;

		public Image backing;
	}

	[SerializeField]
	protected LocalizedUGUIText abilityNameText;

	[SerializeField]
	private List<SuperAbilityFeatureUI> featureUIs;

	[SerializeField]
	private GameObject swapButtonGO;

	[SerializeField]
	private GameObject promptTextGO;

	[SerializeField]
	private AdvancedButton unlockButton;

	[SerializeField]
	private MasterPopupData upgradePopupData;

	[SerializeField]
	private Color activeTextColor;

	[SerializeField]
	private Color inactiveTextColor;

	[SerializeField]
	private Sprite activeBackground;

	[SerializeField]
	private Sprite inactiveBackground;

	private Character character;

	private SignatureAbility superAbility;

	private int[] superAbilityLevels;

	private int activeFeatureSet;

	private bool superAbilityUnlocked;

	private int selectedFeatureSet;

	private int costMultiplier;

	public void Show(bool immediate = false)
	{
	}

	public void Hide(bool immediate = false)
	{
	}

	public void Populate(Character inCharacter)
	{
	}

	public void UGUI_SelectFeatureSet(int index)
	{
	}

	public void UGUI_SwapAbilityPressed()
	{
	}

	public void UGUI_UpgradeAbilityPressed(int featureSet)
	{
	}

	public void UGUI_UnlockButtonPressed()
	{
	}

	private void RefreshFeatureUIs()
	{
	}

	private void SendUnlockRequest()
	{
	}

	private void SendUpgradeRequest(int featureSet)
	{
	}

	private void SendSwapRequest(int newFeatureSet)
	{
	}

	private void CompleteSuperAbilityAction(Price price, int featureSet, string fanfareSubtitle)
	{
	}
}
