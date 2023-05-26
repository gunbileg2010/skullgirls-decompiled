using System;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionCelebrationPopup : SGUGUIPopup
{
	private enum EvoCelebrateState
	{
		Prepare = 0,
		Enter = 1,
		Feed = 2,
		WaitForHit = 3,
		Spin = 4,
		HoldAtEnd = 5,
		Exit = 6
	}

	public class EvolutionCelebrationPopupContext
	{
		public Character evolvingCharacter;

		public List<Character> foodCharacters;

		public bool addEssences;

		public bool becameShiny;
	}

	private const float squareRes = 1.3333334f;

	private const float wideRectRes = 2.0555556f;

	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private EvolutionCelebrationPopup_AnimHelper animHelper;

	[SerializeField]
	private Transform targetCardParent_PreEvo;

	[SerializeField]
	private Transform targetCardParent_PostEvo;

	[SerializeField]
	private EvolutionCelebrationPopop_FoodItemUI[] cardFoodItems;

	[SerializeField]
	private EvolutionCelebrationPopop_FoodItemUI[] essenceFoodItems;

	[SerializeField]
	private CanvasGroup bg;

	[SerializeField]
	private AudioClip sfxClip;

	[SerializeField]
	private Material actorWhiteOutMaterial;

	[SerializeField]
	private ParticleSystem spinParticles;

	[SerializeField]
	private float actorXPosition;

	[SerializeField]
	private float actorSquareResScaleUp;

	[SerializeField]
	private int cardHit_HitsparkIndex;

	[SerializeField]
	private float delayBetweenFoodItems;

	[SerializeField]
	private Vector3 cardGulpAnimScaleAddition;

	[SerializeField]
	private float delayAfterIntroFinish;

	[SerializeField]
	private float holdVictoryPoseTime;

	[SerializeField]
	private float musicVolumeLevel;

	[SerializeField]
	private Animation anim;

	[SerializeField]
	private AnimationClip prepareAnimClip;

	[SerializeField]
	private AnimationClip enterAnimClip;

	[SerializeField]
	private AnimationClip waitForHitAnimClip;

	[SerializeField]
	private AnimationClip spinAnimClip;

	[SerializeField]
	private AnimationClip holdAtEndAnimClip;

	[SerializeField]
	private AnimationClip exitAnimClip;

	[SerializeField]
	private PopupData myData;

	[SerializeField]
	private BaseCharacterData targetPreviewCharacterType;

	private EvoCelebrateState state;

	private EvolutionCelebrationPopupContext context;

	private CharacterCard preEvoCard;

	private CharacterCard postEvoCard;

	private List<CharacterCard> feederCards;

	private Actor actor;

	private float holdTime;

	private bool hasSeenHit;

	private Vector3 targetCardParent_PreEvo_StartScale;

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void PreviewSilverEvolution()
	{
	}

	public void PreviewGoldEvolution()
	{
	}

	public void PreviewDiamondEvolution()
	{
	}

	public void SpawnHitspark(float value)
	{
	}

	public void TimesteppedUpdate()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private CharacterCard AddCard(Character target, Transform parent, bool evolveDown = false, bool becameShiny = false)
	{
		return null;
	}

	private void FindCharacterForPreview(RarityTier tier, Action<Character> callback)
	{
	}

	private void PreviewAnimation(Character target, int foodCount, bool addEssence = false)
	{
	}
}
