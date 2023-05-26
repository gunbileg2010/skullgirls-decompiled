using System.IO;
using UnityEngine;

public class CharacterAbility : MonoBehaviour
{
	public enum ButtonMode
	{
		None = 0,
		Press = 1,
		Tap = 2,
		TapSticky = 3
	}

	[SerializeField]
	protected string title;

	[SerializeField]
	protected string description;

	[SerializeField]
	public bool instantiateWhenCALocked;

	protected Actor assignedActor;

	protected Character assignedCharacter;

	protected ModifierIcon icon;

	private static int instanceIdCounter;

	private int instanceId;

	private void OnDestroy()
	{
	}

	public virtual void Init(Actor actor)
	{
	}

	public static void ResetInstanceIdCounter()
	{
	}

	public int GetCAInstanceId()
	{
		return 0;
	}

	public virtual ButtonMode GetButtonMode(int buttonId = 0)
	{
		return default(ButtonMode);
	}

	public virtual uint GetStickyInputClearTag(int buttonId = 0)
	{
		return 0u;
	}

	public virtual void OnButtonDown(int buttonId = 0)
	{
	}

	public virtual void OnButtonUp(int buttonId = 0)
	{
	}

	public void SetAssignedActor(Actor actor)
	{
	}

	public Actor GetAssignedActor()
	{
		return null;
	}

	public string GetTitle()
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	public virtual PalettizedImage GetPalettizedImage(int buttonId = 0)
	{
		return null;
	}

	public virtual bool ShouldDisplayInPauseScreen()
	{
		return false;
	}

	public virtual string GetPauseScreenTitle()
	{
		return null;
	}

	public virtual string GetPauseScreenDescription()
	{
		return null;
	}

	public virtual Sprite GetPauseScreenSprite()
	{
		return null;
	}

	public virtual void SaveState(BinaryWriter writer)
	{
	}

	public virtual void LoadState(BinaryReader reader)
	{
	}

	public virtual bool CompareState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public virtual void ResetCAButtonPostGameStateLoad()
	{
	}

	protected CharacterAbilityButton GetCharacterAbilityButton()
	{
		return null;
	}

	protected virtual void OnMatchStarted(object passed)
	{
	}

	protected virtual void OnPointCharacterChanged(object passed)
	{
	}

	protected virtual void OnAniEvent(object passed)
	{
	}

	protected virtual void OnActorWasHit(object passed)
	{
	}

	protected virtual void OnActorLandedCrit(object passed)
	{
	}

	protected virtual void OnActorLandedHit(object passed)
	{
	}

	protected virtual void OnActorWhiffedHit(object passed)
	{
	}

	protected virtual void OnActorAboutToBeHit(object passed)
	{
	}

	protected virtual void OnActorAboutToTagOut(object passed)
	{
	}

	protected virtual void OnActorAboutToDie(object passed)
	{
	}

	protected virtual void OnFightFrameUpdated(object passed)
	{
	}

	protected virtual void OnFightTimerTicked(object passed)
	{
	}
}
