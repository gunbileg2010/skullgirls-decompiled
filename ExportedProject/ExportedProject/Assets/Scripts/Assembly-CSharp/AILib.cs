using System.Collections;

public class AILib
{
	public const float VERY_CLOSE = 15.5f;

	public const float CLOSE = 31.25f;

	public const float MID = 62.5f;

	public const float FAR = 93.75f;

	public const float INFINITE = 62500f;

	protected AIInputProvider aiInputProvider;

	protected int difficulty;

	protected float normalizedDifficulty;

	protected float inverseNormalizedDifficulty;

	public virtual void Init(AIInputProvider aiInputProvider)
	{
	}

	public virtual void Enable()
	{
	}

	public virtual void Disable()
	{
	}

	public virtual void SetDifficulty(int diff)
	{
	}

	public int GetDifficulty()
	{
		return 0;
	}

	protected Actor GetPt()
	{
		return null;
	}

	protected Actor GetA1()
	{
		return null;
	}

	protected Actor GetA2()
	{
		return null;
	}

	protected Actor GetE()
	{
		return null;
	}

	protected Actor GetEA1()
	{
		return null;
	}

	protected Actor GetEA2()
	{
		return null;
	}

	protected Actor GetActor(int number)
	{
		return null;
	}

	protected Actor GetActor(int playerNumber, int index)
	{
		return null;
	}

	protected void TagTo(int changeTo)
	{
	}

	protected bool IsBlockingAllowed()
	{
		return false;
	}

	protected bool BackedIntoCorner()
	{
		return false;
	}

	protected bool IsInKnockdown(Actor actor)
	{
		return false;
	}

	protected int GetFightDifficulty()
	{
		return 0;
	}

	protected void ProjectEnemy(int frames, out float xDiff, out float yDiff, out bool enemyGrounded)
	{
		xDiff = default(float);
		yDiff = default(float);
		enemyGrounded = default(bool);
	}

	protected void ProjectActor(Actor referenceActor, Actor projectedActor, int frames, out float xDiff, out float yDiff, out bool isGrounded)
	{
		xDiff = default(float);
		yDiff = default(float);
		isGrounded = default(bool);
	}

	protected void ProjectActorPositionDifference(Actor actor1, Actor actor2, int frames, out float xDiff, out float yDiff, out bool isGrounded)
	{
		xDiff = default(float);
		yDiff = default(float);
		isGrounded = default(bool);
	}

	protected IEnumerator DoNothing()
	{
		return null;
	}

	protected IEnumerator Wait(int frames)
	{
		return null;
	}

	protected IEnumerator WaitForGround()
	{
		return null;
	}

	protected IEnumerator WaitForIdle()
	{
		return null;
	}

	protected void SetStatus(string status)
	{
	}

	protected void Print(object message)
	{
	}
}
