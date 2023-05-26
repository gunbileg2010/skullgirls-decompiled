using System.Collections.Generic;
using UnityEngine;

public class SGEnvironment : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	public Renderer fightPlane;

	public List<Material> opaqueMaterials;

	public List<Renderer> renderOrder;

	[SerializeField]
	private List<FightCharacterStageModifier> fightCharacterStageModifiers;

	[SerializeField]
	private GameObject[] turnOnInFight;

	private static int reactionBB3;

	private static int matchStart;

	private static int enemyDied;

	private static int playerDied;

	private static int normalizedSystemTime12Hour;

	private static int normalizedSystemTime24Hour;

	private static int normalizedSystemTimeMin;

	private List<UVFramesAnimation> uvFrameAnimations;

	private List<SpriteFrameAnimation> spriteFrameAnimations;

	private bool animatorhasSystemTimeMinuteParam;

	private bool animatorhasSystemTime12HourParam;

	private bool animatorhasSystemTime24HourParam;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Update()
	{
	}

	public void SetInFightCharacters(List<Character> playerTeam, List<Character> enemyTeam)
	{
	}

	public void PlayAnimation(string animName, bool loop = false, bool interrupt = false)
	{
	}

	public void PlayAnimationOnObject(string objectName, string animName)
	{
	}

	public void TriggerAnimator(int trigger)
	{
	}

	public Animator GetAnimator()
	{
		return null;
	}

	private void ExplicitlyDefineRenderOrder()
	{
	}

	private void BlockbusterReaction(object data)
	{
	}

	private void MatchStartReaction(object data)
	{
	}

	private void ActorDiedReaction(object data)
	{
	}

	private void TestTinyHit()
	{
	}

	private void TestHitLight()
	{
	}

	private void TestHitMedium()
	{
	}

	private void TestHitHard()
	{
	}

	private void TestHitSuperHard()
	{
	}

	private void TestHitUltraHard()
	{
	}
}
