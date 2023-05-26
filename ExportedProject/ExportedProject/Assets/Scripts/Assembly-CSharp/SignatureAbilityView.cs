using System;
using UnityEngine;
using UnityEngine.UI;

public class SignatureAbilityView : MonoBehaviour
{
	[Serializable]
	public class SignatureAbilityFeatureSetViewContainer
	{
		public GameObject container;

		public LocalizedUGUIText description;

		public GameObject lockGo;

		public Image checkmark;

		public Image background;

		public void SetActive(bool active)
		{
		}

		public void SetLocked(bool isLocked)
		{
		}
	}

	[SerializeField]
	private LocalizedUGUIText signatureAbilityNameText;

	[SerializeField]
	private LocalizedUGUIText level;

	[SerializeField]
	private SignatureAbilityFeatureSetViewContainer signatureAbilityFeatureSet0;

	[SerializeField]
	private SignatureAbilityFeatureSetViewContainer signatureAbilityFeatureSet1;

	[SerializeField]
	private Color activeTextColor;

	[SerializeField]
	private Color inactiveTextColor;

	[SerializeField]
	private Sprite activeBackground;

	[SerializeField]
	private Sprite inactiveBackground;

	public void SetupFromSignatureAbility(Character character)
	{
	}

	public void SetupFromSuperAbility(Character character)
	{
	}

	public void SetupFromPrestigeAbility(Character character, int overrideLevel = -1)
	{
	}

	private Color GetColorForState(bool isActive, bool isHighlight = false)
	{
		return default(Color);
	}

	private void SetupDescriptionFromSignatureAbility(SignatureAbilityFeatureSetViewContainer container, SignatureAbility signatureAbility, int featureSetLevel, int idx)
	{
	}

	private void SetupDescriptionFromSuperAbility(SignatureAbilityFeatureSetViewContainer container, SignatureAbility signatureAbility, bool abilityUnlocked, int featureSetLevel, int featureSetIndex, int activeFeature)
	{
	}

	private void SetupDescriptionFromPrestigeAbility(SignatureAbilityFeatureSetViewContainer container, PrestigeAbility prestigeAbility, bool abilityUnlocked, int abilitylevel)
	{
	}
}
