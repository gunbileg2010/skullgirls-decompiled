using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDetailsDebugPopup : MonoBehaviour
{
	[SerializeField]
	private InputField setLevelInput;

	[SerializeField]
	private InputField grantXpInput;

	[SerializeField]
	private InputField setMALevelInput;

	[SerializeField]
	private InputField setPALevelInput;

	private Character character;

	private Action onChangedCallback;

	public void Show(Character character, Action onChangedCallback)
	{
	}

	public void Hide()
	{
	}

	public void UGUI_SetCharLevel()
	{
	}

	public void UGUI_GrantXp()
	{
	}

	public void UGUI_ToggleShiny()
	{
	}

	public void UGUI_Evolve()
	{
	}

	public void UGUI_SetSuperAbilityLevel()
	{
	}

	public void UGUI_SelectSuperAbility(int index)
	{
	}

	public void UGUI_MaxSkillTree()
	{
	}

	public void UGUI_SetPrestigeAbilityLevel()
	{
	}
}
