using UnityEngine;

[ExecuteInEditMode]
public class SlotOpsCondition : Condition
{
	[SerializeField]
	private string slotOpsStatement;

	[SerializeField]
	private byte applySlotOpsButtonByte;

	[SerializeField]
	[HideInInspector]
	private SlotOpChain slotOps;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
