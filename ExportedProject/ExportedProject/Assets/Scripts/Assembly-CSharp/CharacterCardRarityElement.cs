using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCardRarityElement : MonoBehaviour
{
	[Serializable]
	public class InternalRarityTierConfiguration
	{
		public RarityTier targetTier;

		public Material tierMaterial;

		public bool useArtSettingsTierMaterial;
	}

	[Serializable]
	public class InternalLockableImage
	{
		public Image image;

		[SerializeField]
		private Sprite unlockedSprite;

		[SerializeField]
		private Sprite lockedSprite;

		[SerializeField]
		private bool adjustScale;

		[SerializeField]
		private Vector3 unlockedScale;

		[SerializeField]
		private Vector3 lockedScale;

		[SerializeField]
		private bool adjustAnchorPosition;

		[SerializeField]
		private Vector2 unlockedAnchorPosition;

		[SerializeField]
		private Vector2 lockedAnchorPosition;

		[SerializeField]
		private GameObject[] turnOnWithLock;

		[SerializeField]
		private GameObject[] turnOffWithLock;

		[SerializeField]
		private Image[] childImagesToInheritColor;

		public void SetLockStatus(bool isLocked)
		{
		}

		public void SetColor(Color color)
		{
		}
	}

	[SerializeField]
	private InternalRarityTierConfiguration[] rarityTierConfigurations;

	[SerializeField]
	private Image[] affectedImages;

	[SerializeField]
	private InternalLockableImage[] affectedLockableImages;

	[SerializeField]
	private bool updateMaterials;

	[SerializeField]
	private bool turnOnOffGameObject;

	public void SetRarityTier(RarityTier tier)
	{
	}

	public void SetRarityAndElement(RarityTier tier, Element element)
	{
	}

	public void SetLockedStatus(bool isLocked)
	{
	}

	public void SetColor(Color color)
	{
	}

	public void Hide()
	{
	}

	private InternalRarityTierConfiguration GetRarityConfig(RarityTier tier)
	{
		return null;
	}

	private void UpdateImageWithRarityAndTier(InternalRarityTierConfiguration config, Image image, RarityTier tier, Element element)
	{
	}
}
