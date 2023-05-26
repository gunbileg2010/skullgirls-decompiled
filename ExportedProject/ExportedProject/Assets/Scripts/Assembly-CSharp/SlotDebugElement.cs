using UnityEngine;
using UnityEngine.UI;

public class SlotDebugElement : MonoBehaviour
{
	[SerializeField]
	private InputField slotInput;

	[SerializeField]
	private Text slotLabel;

	private SlotValueHolder currentSVH;

	private Slot currentSlot;

	public void SetSVHSlot(SlotValueHolder svh, Slot slot)
	{
	}

	public void RefreshValue()
	{
	}

	public void UGUI_WriteSlot()
	{
	}
}
