using System.Collections;
using System.Collections.Generic;

public class AICoroutines
{
	private List<IEnumerator> coroutines;

	public int Count => 0;

	public bool Running => false;

	public void Start(IEnumerator routine)
	{
	}

	public void StopAll()
	{
	}

	public void Step()
	{
	}

	private bool MoveNext(IEnumerator routine)
	{
		return false;
	}
}
