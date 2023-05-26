using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDetailsScreen : MonoBehaviour
{
	public enum CharacterDetailsButtonType
	{
		None = 0,
		InfoPanel = 1,
		CharacterBio = 2,
		PowerUpButton = 4,
		StatsPanel = 8,
		EquipPanel = 16,
		SellButton = 32,
		UpgradeButton = 64,
		SkillTreeButton = 128,
		All = 255
	}

	public class Context
	{
		private List<Character> characters;

		public bool usingExistingActors
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int characterIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int characterCount => 0;

		public Context(Character character)
		{
		}

		public Context(List<Character> characters, int currentIndex)
		{
		}

		public Character GetCharacter(int index = -1)
		{
			return null;
		}

		public bool MovePrev()
		{
			return false;
		}

		public bool MoveNext()
		{
			return false;
		}
	}

	[SerializeField]
	private Toggle favoriteToggle;

	[SerializeField]
	private FavoriteButtonController favoriteButtonLogic;

	[SerializeField]
	private Image shinyIndicator;

	[SerializeField]
	private Image shinyBG;

	[SerializeField]
	private Toggle infoTab;

	[SerializeField]
	private CharacterDetailsInfoPanel infoPanel;

	[SerializeField]
	private CharacterBioPopupData bioPopupData;

	[SerializeField]
	[TextArea]
	private string experienceProgressPopupLocKey;

	[SerializeField]
	private Toggle statsTab;

	[SerializeField]
	private CharacterDetailsStatsPanel statsPanel;

	[SerializeField]
	private Toggle equipTab;

	[SerializeField]
	private GearEquipController gearEquipController;

	[SerializeField]
	private GameObject leftArrowGO;

	[SerializeField]
	private GameObject rightArrowGO;

	[SerializeField]
	private RectTransform actorInputZone;

	[SerializeField]
	private CharacterDetailsDebugPopup debugPopup;

	private GameState gameState;

	private Context screenContext;

	private bool didSpawnEnvironment;

	private Character currentCharacter;

	private bool isCharacterInitiallyLocked;

	private Actor actor;

	private PlayerController controller;

	private int screenInstanceId;

	private List<Gear> equippedGearOnEnter;

	private const int kTopBarConfiguration = 1048588;

	private int disabledButtonMask;

	private static bool tutorialMode;

	private bool isGoingToBeConverted;

	private ContextualPopupItem experienceContextualPopup;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public static void SetTutorialMode(bool value)
	{
	}

	public void SetDisabledButtonMask(int mask)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public void UGUI_SummaryTabToggle(bool show)
	{
	}

	public void UGUI_StatsTabToggle(bool show)
	{
	}

	public void UGUI_GearPanelToggle(bool show)
	{
	}

	public void UGUI_OnBioButtonPress()
	{
	}

	public void UGUI_OnPowerUpButtonPress()
	{
	}

	public void UGUI_MasteryButtonPress()
	{
	}

	public void UGUI_LockCharacterToggle()
	{
	}

	public void UGUI_LeftArrowPressed()
	{
	}

	public void UGUI_RightArrowPressed()
	{
	}

	public void UGUI_ToggleExperienceProgressTooltip()
	{
	}

	public void UGUI_OpenWiki()
	{
	}

	public void DEBUG_OpenCharacterDebugPopup()
	{
	}

	public void DEBUG_CharacterShare()
	{
	}

	public void DEBUG_LevelUp(int level)
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

	private void OnGearDetailsStateChanged(bool activeState)
	{
	}

	private void SetInputZoneBounds(TouchInputProvider.TouchRestrictions restrictions)
	{
	}

	private IEnumerator RefreshFromContext()
	{
		return null;
	}

	private void RefreshStatsPanelData()
	{
	}

	private void SendEquipGearRequestIfNeeded(Action doneCallback)
	{
	}

	private void SendEquipGearRequest(Action doneCallback)
	{
	}

	private void CleanUp()
	{
	}

	protected bool IsButtonDisabled(CharacterDetailsButtonType type)
	{
		return false;
	}

	private void UpdateCameraPosition(Actor actorToFocus, BaseCharacterData baseData, float duration)
	{
	}

	private void OnStateChanged(string fromState, string toState)
	{
	}
}
