using System.IO;

public class ZInput
{
	private ZButton primaryButton;

	private ZButtonState[] buttons;

	private ushort chargeTime;

	private SlotOpChain slotOpsToMatch;

	public static int GetMaskValueForButton(ZButton button)
	{
		return 0;
	}

	public ZInput()
	{
	}

	public ZInput(bool buttonsUp, ZButton type = ZButton.NONE)
	{
	}

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}

	public bool UsesButtons()
	{
		return false;
	}

	public bool EqualTo(ZInput otherInput, SlotValueHolder svh = null)
	{
		return false;
	}

	public void SetButton(ZButton button, ZButtonState buttonState)
	{
	}

	public int GetButtonInputMask()
	{
		return 0;
	}

	public int GetChargeTime()
	{
		return 0;
	}

	public SlotOpChain GetSlotOpChain()
	{
		return null;
	}

	public ZButton GetButton()
	{
		return default(ZButton);
	}

	public override string ToString()
	{
		return null;
	}

	private bool DoButtonStatesMatch(ZButtonState myButtonState, ZButtonState otherButtonState)
	{
		return false;
	}
}
