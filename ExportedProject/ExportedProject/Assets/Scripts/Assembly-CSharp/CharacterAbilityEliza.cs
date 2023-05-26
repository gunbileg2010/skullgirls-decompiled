using System.IO;
using UnityEngine;

public class CharacterAbilityEliza : CharacterAbility
{
	[SerializeField]
	private PalettizedImage elizaImage;

	[SerializeField]
	private float timeInSekhmet;

	[SerializeField]
	private ModifierIcon sekhmetIcon;

	private const int kSekhmetTimeUpFlag = 30;

	private uint sekhmetTag;

	private uint returnTag;

	private int timer;

	private int framesInSekhmet;

	private bool sekhmetActive;

	private float preSekhmetRedLife;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override ButtonMode GetButtonMode(int buttonId = 0)
	{
		return default(ButtonMode);
	}

	public override PalettizedImage GetPalettizedImage(int buttonId)
	{
		return null;
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public override void ResetCAButtonPostGameStateLoad()
	{
	}

	protected override void OnFightFrameUpdated(object passed)
	{
	}

	private void ToggleSekhmet(bool isActive)
	{
	}

	private void StartTimer()
	{
	}

	private void ShowHideSekhmetIcon(bool show)
	{
	}
}
