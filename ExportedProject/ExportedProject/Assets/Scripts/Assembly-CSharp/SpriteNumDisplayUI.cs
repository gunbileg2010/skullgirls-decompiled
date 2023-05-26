using System;
using UnityEngine;
using UnityEngine.UI;

public class SpriteNumDisplayUI : MonoBehaviour
{
	[Serializable]
	public class SpriteNumDisplayDigit
	{
		public Image digitImage;

		public GameObject commaObject;

		public UIGradient32 gradient;

		public UIGradient32 commaGradient;

		public void GrabGradients()
		{
		}

		public void EnableWithSprite(Sprite sprite)
		{
		}

		public void Disable()
		{
		}
	}

	[SerializeField]
	private SpriteNumDisplayDigit[] digitImages;

	[SerializeField]
	private UIGradient32[] additionalGradients;

	[SerializeField]
	private bool populateOnEnable;

	[SerializeField]
	private int onEnableValue;

	private int? cachedNumber;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Populate(int number)
	{
	}

	public void SetGradient(Color32 topColor, Color32 bottomColor)
	{
	}

	public void SetGradient(Gradient gradient)
	{
	}
}
