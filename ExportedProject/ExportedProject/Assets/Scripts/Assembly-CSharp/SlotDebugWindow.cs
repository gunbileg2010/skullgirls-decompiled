using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotDebugWindow : MonoBehaviour
{
	[SerializeField]
	private SlotDebugElement slotPrototype;

	[SerializeField]
	private Dropdown actorDropdown;

	[SerializeField]
	private Toggle togglePlayerTeam;

	private DebugSettings debugSettings;

	private List<SlotDebugElement> slots;

	private Actor currentActor;

	private List<Actor> actors;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ChangeVisibility(bool visible)
	{
	}

	public void UGUI_CloseWindow()
	{
	}

	public void RefreshAvailableActors()
	{
	}

	private void CreateSlots()
	{
	}

	private void RefreshSlots()
	{
	}

	private void UpdateSelectedActor()
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}

	private void OnMatchStarted(object passed)
	{
	}
}
