using System.Collections;

public interface IGameState
{
	string StateName { get; }

	IEnumerator Show(IGameState previousState, object context);

	IEnumerator Hide(IGameState nextState);
}
