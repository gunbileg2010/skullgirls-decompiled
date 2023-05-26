using System.Collections.Generic;

public class SetTeamCompositionSequentialAction : SequentialAction
{
	public List<CharacterGenerator> playerCharacterGenerators;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}

	private void SetGearAction(List<Character> newTeamCharacters, int index)
	{
	}

	private void SetTeamAction(List<Character> newTeamCharacters)
	{
	}
}
