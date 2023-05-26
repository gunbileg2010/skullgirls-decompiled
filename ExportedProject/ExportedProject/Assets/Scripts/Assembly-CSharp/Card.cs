using System;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
	public enum ButtonSelectionMethod
	{
		Clicked = 0,
		LongPress = 1
	}

	[SerializeField]
	private GameObject newSticker;

	public static readonly Action<Card> kDoNothing;

	private Action<Card> clickCallback;

	protected Card innerCard;

	protected ButtonSelectionMethod waySelected;

	public Card GetInnermostCard()
	{
		return null;
	}

	public T GetInnermostCard<T>() where T : Card
	{
		return null;
	}

	public void SetNewSticker(bool value)
	{
	}

	public virtual void Clear()
	{
	}

	public void SetClickCallback(Action<Card> callback)
	{
	}

	public ButtonSelectionMethod GetSelectionMethod()
	{
		return default(ButtonSelectionMethod);
	}

	protected bool CallClickCallback()
	{
		return false;
	}
}
