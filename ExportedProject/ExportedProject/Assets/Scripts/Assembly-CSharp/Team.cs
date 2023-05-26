using System;
using System.Collections.Generic;
using System.IO;

public class Team
{
	public Action<Team, Character> OnPointCharacterChanged;

	public const int kMaxTeamSize = 3;

	private TeamType teamType;

	private int playerNumber;

	private List<Character> characters;

	private List<int> characterOrder;

	private Fixed prevPointSuperbar;

	private int[] tagInFrameTimers;

	private int[] tagInFrameTimersMax;

	public Team(int playerNumber, TeamType teamType, List<Character> characters)
	{
	}

	public void Clear()
	{
	}

	public void SwitchPointCharacter(int changeTo)
	{
	}

	public void StartTagInCooldowns(int teamPos = 0)
	{
	}

	public void ResetTagInCooldowns()
	{
	}

	public void DecrementTagInCooldowns()
	{
	}

	public bool AreTagInsDisabled()
	{
		return false;
	}

	public bool CanTagInAnyone()
	{
		return false;
	}

	public bool CanTagInActor(int actorTeamPos)
	{
		return false;
	}

	public float GetTagInTimer(Actor actor)
	{
		return 0f;
	}

	public static int GetTeamFighterScore(IList<Character> teamCharacters)
	{
		return 0;
	}

	public int GetTeamFighterScore()
	{
		return 0;
	}

	public int GetCombinedLife()
	{
		return 0;
	}

	public int GetCombinedMaxLife()
	{
		return 0;
	}

	public float GetCombinedLifePercent()
	{
		return 0f;
	}

	public bool IsTeamDead()
	{
		return false;
	}

	public Character GetCharacter(int index)
	{
		return null;
	}

	public Character GetPointCharacter()
	{
		return null;
	}

	public List<Character> GetOrderedCharacters()
	{
		return null;
	}

	public List<Character> GetCharacters()
	{
		return null;
	}

	public void ReplaceCharacterAt(int index, Character newCharacter)
	{
	}

	public Actor GetActor(int index)
	{
		return null;
	}

	public List<Actor> GetActors()
	{
		return null;
	}

	public Actor GetPointActor()
	{
		return null;
	}

	public TeamType GetTeamType()
	{
		return default(TeamType);
	}

	public int GetPlayerNumber()
	{
		return 0;
	}

	public int GetTeamSize()
	{
		return 0;
	}

	public float GetSuperbarFrameDiff()
	{
		return 0f;
	}

	public bool IsUsingLastCharacter()
	{
		return false;
	}

	public void ClearModifiers(bool removePermanent)
	{
	}

	public void ResetSpecialCooldowns()
	{
	}

	public void SetSlotForAll(Slot slot, float value)
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	private void AddCharacterAt(int index, Character character)
	{
	}

	private void RemoveCharacterAt(int index)
	{
	}
}
