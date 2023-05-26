using System;
using System.Collections.Generic;
using UnityEngine;

public class LoadingUI : MonoSingleton<LoadingUI>
{
	[SerializeField]
	private FightLoadingScreen fightLoadingScreen;

	[SerializeField]
	private CornerLoadingIcon cornerLoadingIcon;

	[SerializeField]
	private CenterLoadingIcon centerLoadingIcon;

	private int lastHintIndex;

	protected override void Awake()
	{
	}

	public void ShowFightLoading(List<BaseCharacterData> loadingCharacters = null, Action callback = null)
	{
	}

	public void HideFightLoading()
	{
	}

	public void ShowCornerLoading(string status = "", bool immediate = false)
	{
	}

	public void HideCornerLoading(bool immediate = false)
	{
	}

	public void ShowCenterLoading(string status = "")
	{
	}

	public void HideCenterLoading()
	{
	}

	public bool IsShowingAnyLoading()
	{
		return false;
	}

	private List<BaseCharacterData> SelectRandomCharactersIfNull(List<BaseCharacterData> loadingCharacters)
	{
		return null;
	}

	public LoadingUI()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
