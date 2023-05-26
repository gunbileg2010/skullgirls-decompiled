using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class GearEquipController : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	[SerializeField]
	private RecycledScrollList recycledScrollList;

	[SerializeField]
	private SortAndFilterUI sortAndFilter;

	[SerializeField]
	private List<GearCardSlot> gearSlots;

	[SerializeField]
	private Transform draggingArea;

	[SerializeField]
	private Text gearPointsText;

	[SerializeField]
	private Button equipButton;

	[SerializeField]
	private GameObject unequipButton;

	[SerializeField]
	private GameObject cancelButton;

	[SerializeField]
	private GameObject screenDim;

	[SerializeField]
	private GameObject equipInstructions;

	[SerializeField]
	private GameObject gearDetailsButtons;

	[SerializeField]
	private GearDetailsView gearDetails;

	[SerializeField]
	private UnityEvent toggleGearView;

	[SerializeField]
	private GearLoadoutsPanel loadoutsPanel;

	[SerializeField]
	private Button loadoutsButton;

	private static bool tutorialMode;

	private static GearSortAndFilter gearSortAndFilter;

	private Character character;

	private List<Gear> gearCollection;

	private List<Gear> filteredAndSortedGearCollection;

	private Gear selectedGear;

	private bool equipMode;

	private Action equipCallback;

	private Action<bool> gearDetailsActiveStateChanged;

	private Stack<GearCardHolder> availableGearCardHolders;

	private Dictionary<Gear, GearCardHolder> inventoryCardHolders;

	private Dictionary<Gear, GearCardHolder> equippedCardHolders;

	private GearCardHolder lastCardHolder;

	private List<GameObject> tutorialIndicators;

	private Gear pointedAtGear;

	public event Action<Gear> GearSold
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Gear> GearUpgraded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Gear> GearLockStateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action GearEquipped
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}

	public void Populate(Character character, Action equipCallback, bool tutorialMode = false, Action callback = null)
	{
	}

	public void SetVisible(bool show)
	{
	}

	public void SetIsListeningToGearDetailsActiveStateChanged(bool isListening, Action<bool> callback)
	{
	}

	public void Clear()
	{
	}

	public void SetGearDetailsVisible(bool visible)
	{
	}

	public void OnDrop(PointerEventData eventData)
	{
	}

	public void OnTapGearSlot(GearCardSlot slot)
	{
	}

	public void UGUI_CloseGearDetails()
	{
	}

	public void UGUI_UnequipGear()
	{
	}

	public void UGUI_EquipGear()
	{
	}

	public void UGUI_CancelEquip()
	{
	}

	public void UGUI_OpenLoadouts()
	{
	}

	public void UGUI_CloseLoadouts()
	{
	}

	public void SetTutorialMode(bool value)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public void PointAtGearSlot(int slotIdx, List<TutorialIndication> indications)
	{
	}

	public void PointAtGearIndex(int gearIdx, List<TutorialIndication> indications)
	{
	}

	public void PointAtGear(GearData gearData, List<TutorialIndication> indications, Action<bool> callback = null)
	{
	}

	public void HideInspectionPopups()
	{
	}

	public void HidePopups()
	{
	}

	public void TryEquipLoadout(GearLoadout gearLoadout, Action<bool> callback = null)
	{
	}

	public bool VerifyIfLoadoutIsEquippable(GearLoadout gearLoadout, bool showPopups = true)
	{
		return false;
	}

	public void UpdateExternalGearSelection(bool selected, Gear gear = null)
	{
	}

	public Gear GetSelectedGear()
	{
		return null;
	}

	private RectTransform OnAddGearScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveGearScrollItem(RectTransform item)
	{
	}

	private void OnGearSortOrFilterChanged()
	{
	}

	private void OnGearLockStateChanged()
	{
	}

	private void CompleteEquipAction()
	{
	}

	private void RefreshGearPointsText()
	{
	}

	private void SetEquipMode(bool inEquipMode)
	{
	}

	public bool TryEquipGearToSlot(Gear gear, GearCardSlot slot)
	{
		return false;
	}

	private void EquipGearToSlot(Gear gear, GearCardSlot slot)
	{
	}

	private void DeselectGear()
	{
	}

	private void SwapGearSlot(Gear gear1, Gear gear2)
	{
	}

	private void PutGearInEquippedGearSlot(Gear gear, GearCardSlot slot)
	{
	}

	private void RemoveGearFromEquippedGearSlot(Gear gear, bool removeFromDict = true)
	{
	}

	private void OnSelect(GearCardHolder gearIcon)
	{
	}

	private void SelectGear(Gear gear)
	{
	}

	private void RefreshEquipButtons()
	{
	}

	private void RefreshGearIconGlow(Gear gear)
	{
	}

	private void OnGearUpgraded()
	{
	}

	private void OnGearSold()
	{
	}

	private void SetupTutorialGearSlotEquipTarget()
	{
	}

	private void DestroyTutorialIndicators()
	{
	}

	private void StandUpIndicators(Transform target, List<TutorialIndication> indications, PointDirection pointDirection = PointDirection.Right)
	{
	}

	private void SetLoadoutsPopupVisible(bool visible)
	{
	}

	private void EquipLoadout(GearLoadout gearLoadout)
	{
	}
}
