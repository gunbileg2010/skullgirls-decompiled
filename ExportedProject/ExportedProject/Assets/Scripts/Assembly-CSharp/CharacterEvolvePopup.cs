using UnityEngine;

public class CharacterEvolvePopup : SGUGUIPopup
{
	public class CharacterEvolvePopupContext
	{
		public Character character;

		public bool canEvolve;

		public string instructions;

		public int prestigeGain;
	}

	[SerializeField]
	private CharacterEvolutionView characterEvolutionView;

	private CharacterEvolvePopupContext evolutionContext;

	private int prevNavConfig;

	private string prevNavCurrenciesConfig;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_OnPrestigeInfoButtonPressed()
	{
	}
}
