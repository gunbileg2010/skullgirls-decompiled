using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterCatalogScreen : MonoBehaviour
{
	[SerializeField]
	public RecycledScrollList portraitRecycledScrollList;

	private Stack<CharacterPortrait> availablePortraits;

	[SerializeField]
	public Text ownedFighterCounter;

	[SerializeField]
	private PopupData fighterPreviewPopup;

	[SerializeField]
	private PopupData filterPopupData;

	[SerializeField]
	private GameObject activeFilterSortGlowGO;

	[SerializeField]
	private ContextualTutorial contextualTutorial;

	private CharacterSortAndFilter characterSortAndFilter;

	private List<Character> characterCollection;

	private List<Character> filteredAndSortedCharacterCollection;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UGUI_FilterSortButtonClicked()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void OnCharacterSortOrFilterChanged()
	{
	}

	private RectTransform OnAddCharacterScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveCharacterScrollItem(RectTransform item)
	{
	}

	public void OnPortraitClicked(CharacterPortrait character)
	{
	}
}
