using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshTopBarSequentialAction : SequentialAction
{
	[SerializeField]
	private List<TopBar.TopBarUIElement> elementsToShow;

	[SerializeField]
	private List<CurrencyType> currenciesToShow;

	[SerializeField]
	private VariantCharacterData characterContex;

	[SerializeField]
	private bool immediate;

	private int configuration;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	protected IEnumerator RefreshTopBar()
	{
		return null;
	}
}
