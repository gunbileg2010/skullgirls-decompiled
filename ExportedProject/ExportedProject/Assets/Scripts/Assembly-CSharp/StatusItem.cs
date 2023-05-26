using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusItem : MonoBehaviour
{
	public enum Status
	{
		Locked = 0,
		Inactive = 1,
		Incomplete = 2,
		Active = 3,
		Complete = 4
	}

	[Serializable]
	public class StatusSettings
	{
		public Status status;

		public Color titleTextColor;

		public Color descriptionTextColor;

		public Sprite backgroundSprite;

		public Color backgroundImageColor;

		public Sprite statusImageSprite;

		public Color statusImageColor;
	}

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private Image statusImage;

	[SerializeField]
	private Image background;

	[SerializeField]
	private List<StatusSettings> statusSettings;

	public void SetTitle(string title)
	{
	}

	public void SetDescription(string description)
	{
	}

	public void SetActive(bool active)
	{
	}

	public void SetLocked(bool isLocked)
	{
	}

	public virtual void Populate(string title, string description, Status status)
	{
	}

	public void SetStatus(Status status)
	{
	}
}
