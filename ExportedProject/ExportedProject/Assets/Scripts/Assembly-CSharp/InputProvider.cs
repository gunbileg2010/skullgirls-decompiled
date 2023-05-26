public abstract class InputProvider
{
	private int buttonDisabledMask;

	public virtual void Enable()
	{
	}

	public virtual void Disable()
	{
	}

	public virtual void Update()
	{
	}

	public abstract ZInput GetInput();

	public virtual void EndSustainedInput()
	{
	}

	public void AddInputToMask(int toAdd)
	{
	}

	public void RemoveFromInputMask(int toRemove)
	{
	}

	public bool IsButtonDisabled(int inputMask)
	{
		return false;
	}
}
