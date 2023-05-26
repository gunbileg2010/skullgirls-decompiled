using System.IO;
using UnityEngine;

public class SlotValueHolder
{
	public static Fixed[] globalSlots;

	public const int NUM_FLAGS_UINTS = 4;

	private Fixed[] currentSlotValues;

	private int[] currentSlotBitfield;

	private SlotValueHolder leaderSVH;

	private SlotValueHolder enemySVH;

	private SlotValueHolder throwVictimSVH;

	private SlotValueHolder lastAttackerSVH;

	private SlotValueHolder parentSVH;

	private SlotValueHolder defaultsSVH;

	private Actor owner;

	public void Clear()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void DoArithmeticOps(SlotOpChain toApply)
	{
	}

	public bool AndAllBooleanOps(SlotOpChain toApply)
	{
		return false;
	}

	public float GetColorByPaletteSlot(int index, int colorSlot)
	{
		return 0f;
	}

	public bool CurrentOwnerHasTag(uint toCompare)
	{
		return false;
	}

	public Fixed GetValue(Slot slot)
	{
		return default(Fixed);
	}

	public int GetIntValue(Slot slot)
	{
		return 0;
	}

	public bool GetBoolValue(Slot slot)
	{
		return false;
	}

	public Fixed GetDefaultValue(Slot slot)
	{
		return default(Fixed);
	}

	public void SetValue(Slot slot, Fixed value)
	{
	}

	public void SetValue(Slot slot, float value)
	{
	}

	public void SetValue(Slot slot, int value)
	{
	}

	public uint GetHashValue(Slot slot)
	{
		return 0u;
	}

	public void SetHashValue(Slot slot, uint val)
	{
	}

	public bool GetFlagValue(int flagNum)
	{
		return false;
	}

	public void SetFlagValue(int flagNum, bool val)
	{
	}

	public Vector2 GetThrowVictimPoint(uint pointNameHash)
	{
		return default(Vector2);
	}

	public int GetBitfieldValue(int which)
	{
		return 0;
	}

	public void SetBitfieldValue(int which, int value)
	{
	}

	public void ApplyBitFieldMask(int which, uint mask)
	{
	}

	public void UnapplyBitFieldMask(int which, uint mask)
	{
	}

	public void ResetAllFlagsToZero()
	{
	}

	public void ResetAllSlotValuesToZero()
	{
	}

	public void ResetCurrentSlotsToDefaultValues()
	{
	}

	public SlotValueHolder GetLeaderSVH()
	{
		return null;
	}

	public Actor GetLeaderAsActor()
	{
		return null;
	}

	public void SetLeaderSVH(SlotValueHolder leader)
	{
	}

	public SlotValueHolder GetEnemySVH()
	{
		return null;
	}

	public Actor GetEnemyAsActor()
	{
		return null;
	}

	public void SetEnemySVH(SlotValueHolder enemy)
	{
	}

	public SlotValueHolder GetThrowVictimSVH()
	{
		return null;
	}

	public void SetThrowVictimSVH(SlotValueHolder throwVictim)
	{
	}

	public SlotValueHolder GetLastAttackerSVH()
	{
		return null;
	}

	public Actor GetLastAttackerAsActor()
	{
		return null;
	}

	public void SetLastAttackerSVH(SlotValueHolder lastAttacker)
	{
	}

	public SlotValueHolder GetParentSVH()
	{
		return null;
	}

	public Actor GetParentAsActor()
	{
		return null;
	}

	public void SetParentSVH(SlotValueHolder parent)
	{
	}

	public Actor GetOwner()
	{
		return null;
	}

	public void SetOwner(Actor owner)
	{
	}

	public SlotValueHolder GetDefaultsSVH()
	{
		return null;
	}

	public void SetDefaultsSVH(SlotValueHolder defaults)
	{
	}

	public static void SaveStaticState(BinaryWriter writer)
	{
	}

	public static void LoadStaticState(BinaryReader reader)
	{
	}

	public void SaveState(BinaryWriter writer, Actor callingActor = null)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}
}
