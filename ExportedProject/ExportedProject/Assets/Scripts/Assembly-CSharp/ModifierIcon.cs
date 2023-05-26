using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ModifierIcon : MonoBehaviour
{
	[SerializeField]
	private Image ringImage;

	[SerializeField]
	private GameObject stackingIconPrefab;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private GameObject permanentIconPrefab;

	private GameObject stackingIconGO;

	private GameObject permanentGO;

	private Text stackingText;

	private Coroutine coroutine;

	public ModifierType ModifierType
	{
		[CompilerGenerated]
		get
		{
			return default(ModifierType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ModifierStrength ModifierStrength
	{
		[CompilerGenerated]
		get
		{
			return default(ModifierStrength);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void PopulateArt(ArtSettings.ModifierIconArt modifierArt)
	{
	}

	public void SetRingProgress(float progress)
	{
	}

	public void SetStack(int amount, bool addOne = true)
	{
	}

	public void SetPermanent(bool permanent)
	{
	}

	public void PlayAddStackAnimation()
	{
	}

	public Image GetIcon()
	{
		return null;
	}

	public bool IsPermanent()
	{
		return false;
	}

	private IEnumerator AddStackAnimation()
	{
		return null;
	}
}
