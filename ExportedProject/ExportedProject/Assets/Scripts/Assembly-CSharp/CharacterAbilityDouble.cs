using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CharacterAbilityDouble : CharacterAbility
{
	[SerializeField]
	private float blockTime;

	[SerializeField]
	private Fixed elementalBonus;

	public bool resetOnBlockstun;

	public bool linearElementChoice;

	private List<Element> allElements;

	private int blockTimeFrames;

	private int timeInBlock;

	private bool debuffApplied;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
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

	protected override void OnMatchStarted(object passed)
	{
	}

	protected override void OnFightFrameUpdated(object passed)
	{
	}

	protected override void OnActorAboutToTagOut(object passed)
	{
	}

	protected override void OnPointCharacterChanged(object passed)
	{
	}

	private Element PickRandomValidElement()
	{
		return default(Element);
	}

	private Element PickNextValidElement()
	{
		return default(Element);
	}

	private void UpdateEnemyDisadvantage()
	{
	}
}
