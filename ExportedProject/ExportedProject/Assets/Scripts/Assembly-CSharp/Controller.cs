public abstract class Controller
{
	public enum Type : byte
	{
		None = 0,
		Player = 1,
		Autoplay = 2,
		AI = 3
	}

	private int buttonDisabledMask;

	private ZInput stickyInput;

	private uint stickyInputClearTag;

	private int stickyInputTimer;

	private ZInput scriptedInput;

	private ZInput sustainedInput;

	public virtual void Enable()
	{
	}

	public virtual void Disable()
	{
	}

	public virtual void CleanUp()
	{
	}

	public virtual void Update()
	{
	}

	public abstract ZInput GetInput();

	public virtual void EndSustainedInput()
	{
	}

	public void AddToDisabledButtonMask(int input)
	{
	}

	public void RemoveFromDisabledButtonMask(int input)
	{
	}

	public void SetStickyInput(ZInput input, uint clearTag = 0u)
	{
	}

	public void ClearStickyInput(ZInput inputToClear = null)
	{
	}

	public ZInput GetStickyInput()
	{
		return null;
	}

	public void UpdateStickyInput(Actor pointActor)
	{
	}

	public void SetScriptedInput(ZInput input)
	{
	}

	public void StartSustainedInput(ZInput input)
	{
	}

	public void StopSustainedInput(ZInput inputToStop = null)
	{
	}

	public ZInput GetSustainedInput()
	{
		return null;
	}

	public abstract Type GetControllerType();

	protected bool IsButtonDisabled(int buttonMask)
	{
		return false;
	}

	protected ZInput GetScriptedInput()
	{
		return null;
	}
}
