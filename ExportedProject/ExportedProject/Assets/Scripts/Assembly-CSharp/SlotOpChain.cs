using System;
using System.IO;
using UnityEngine;

[Serializable]
public class SlotOpChain
{
	public enum Operation : byte
	{
		NONE = 0,
		SET = 1,
		ADD = 2,
		SUB = 3,
		MULT = 4,
		DIV = 5,
		ABS = 6,
		INT_PART = 7,
		DEFAULT_VALUE = 8,
		SIN_VALUE = 9,
		COS_VALUE = 10,
		MAX_OF_SRCS = 11,
		MIN_OF_SRCS = 12,
		ATAN2_XY = 13,
		SRC1_IF_SRC2_NONZERO = 14,
		SRC1_IF_SRC2_ISZERO = 15,
		FIRST_BOOL_OP = 16,
		LESS_THAN = 16,
		GREATER_THAN = 17,
		EQUAL_TO = 18,
		GREATER_THAN_OR_EQUAL_TO = 19,
		LESS_THAN_OR_EQUAL_TO = 20,
		NOT_EQUAL_TO = 21,
		HASH_EQUAL_TO = 22,
		HASH_NOT_EQUAL_TO = 23,
		PRINT_SRC1 = 24,
		GET_THROW_PT_X = 25,
		GET_THROW_PT_Y = 26,
		GET_PALETTE_COLOR = 27,
		OR = 28,
		AND = 29,
		MOD = 30,
		SQRT_SRC1 = 31,
		DOES_CURRENT_SPRITE_STATE_HAVE_TAG = 32,
		DOES_CURRENT_SPRITE_STATE_NOT_HAVE_TAG = 33,
		SRC1_POWER_SRC2 = 34,
		ONE_IF_SRC1_EQUALS_SRC2 = 35,
		ONE_IF_SRC1_NOT_EQUALS_SRC2 = 36,
		ONE_IF_SRC1_LESS_THAN_SRC2 = 37,
		ONE_IF_SRC1_CURRENT_SPRITE_STATE_HAS_TAG_SRC2 = 38,
		ONE_IF_SRC1_CURRENT_SPRITE_STATE_DOESNT_HAVE_TAG_SRC2 = 39,
		GET_GENERIC_POINT_OFFSET_X = 40,
		GET_GENERIC_POINT_OFFSET_Y = 41,
		ONE_IF_SRC1_CURRENT_SPRITE_STATE_HAS_LASTHITSLOTOPS = 42,
		CLEAR_LASTHITSLOTOPS_RETURN_1_IF_THERE_WERE_ANY = 43,
		GET_RAW_PT_VALUE_X = 44,
		GET_RAW_PT_VALUE_Y = 45,
		ONE_IF_ANY_ASSIST_IS_ATTACKING = 46,
		ONE_IF_ANY_ASSIST_STATE_HAS_TAG_SRC2 = 47,
		NUM_CHARACTERS_ON_MY_TEAM = 48,
		GET_PALETTE_FX_CYCLE_COUNTER = 49,
		SRC1_CHOSEN_PALETTE_INDEX_EQUALS_SRC2 = 50,
		WORLD_NAME_HASH_EQUALS_SRC2 = 51,
		IS_LAST_LIFEBAR_OF_THIS_GAME = 52,
		SRC1_CHOSEN_VO_INDEX_EQUALS_SRC2 = 53,
		READ_DIGIT_0 = 54,
		READ_DIGIT_1 = 55,
		READ_DIGIT_2 = 56,
		READ_DIGIT_3 = 57,
		READ_DIGIT_4 = 58,
		READ_DIGIT_5 = 59,
		READ_DIGIT_6 = 60,
		READ_DIGIT_7 = 61,
		READ_DIGIT_8 = 62,
		READ_DIGIT_9 = 63,
		CHECK_DIGIT_0_EQUAL = 64,
		CHECK_DIGIT_1_EQUAL = 65,
		CHECK_DIGIT_2_EQUAL = 66,
		CHECK_DIGIT_3_EQUAL = 67,
		CHECK_DIGIT_4_EQUAL = 68,
		CHECK_DIGIT_5_EQUAL = 69,
		CHECK_DIGIT_6_EQUAL = 70,
		CHECK_DIGIT_7_EQUAL = 71,
		CHECK_DIGIT_8_EQUAL = 72,
		CHECK_DIGIT_9_EQUAL = 73,
		CHECK_DIGIT_0_LESSTHAN = 74,
		CHECK_DIGIT_1_LESSTHAN = 75,
		CHECK_DIGIT_2_LESSTHAN = 76,
		CHECK_DIGIT_3_LESSTHAN = 77,
		CHECK_DIGIT_4_LESSTHAN = 78,
		CHECK_DIGIT_5_LESSTHAN = 79,
		CHECK_DIGIT_6_LESSTHAN = 80,
		CHECK_DIGIT_7_LESSTHAN = 81,
		CHECK_DIGIT_8_LESSTHAN = 82,
		CHECK_DIGIT_9_LESSTHAN = 83,
		CHECK_DIGIT_0_GREATERTHAN = 84,
		CHECK_DIGIT_1_GREATERTHAN = 85,
		CHECK_DIGIT_2_GREATERTHAN = 86,
		CHECK_DIGIT_3_GREATERTHAN = 87,
		CHECK_DIGIT_4_GREATERTHAN = 88,
		CHECK_DIGIT_5_GREATERTHAN = 89,
		CHECK_DIGIT_6_GREATERTHAN = 90,
		CHECK_DIGIT_7_GREATERTHAN = 91,
		CHECK_DIGIT_8_GREATERTHAN = 92,
		CHECK_DIGIT_9_GREATERTHAN = 93,
		CHECK_DIGIT_0_LESSTHANEQUALTO = 94,
		CHECK_DIGIT_1_LESSTHANEQUALTO = 95,
		CHECK_DIGIT_2_LESSTHANEQUALTO = 96,
		CHECK_DIGIT_3_LESSTHANEQUALTO = 97,
		CHECK_DIGIT_4_LESSTHANEQUALTO = 98,
		CHECK_DIGIT_5_LESSTHANEQUALTO = 99,
		CHECK_DIGIT_6_LESSTHANEQUALTO = 100,
		CHECK_DIGIT_7_LESSTHANEQUALTO = 101,
		CHECK_DIGIT_8_LESSTHANEQUALTO = 102,
		CHECK_DIGIT_9_LESSTHANEQUALTO = 103,
		CHECK_DIGIT_0_GREATERTHANEQUALTO = 104,
		CHECK_DIGIT_1_GREATERTHANEQUALTO = 105,
		CHECK_DIGIT_2_GREATERTHANEQUALTO = 106,
		CHECK_DIGIT_3_GREATERTHANEQUALTO = 107,
		CHECK_DIGIT_4_GREATERTHANEQUALTO = 108,
		CHECK_DIGIT_5_GREATERTHANEQUALTO = 109,
		CHECK_DIGIT_6_GREATERTHANEQUALTO = 110,
		CHECK_DIGIT_7_GREATERTHANEQUALTO = 111,
		CHECK_DIGIT_8_GREATERTHANEQUALTO = 112,
		CHECK_DIGIT_9_GREATERTHANEQUALTO = 113,
		LERP = 114,
		INVLERP = 115,
		TRUEDIV = 116
	}

	public enum Flags
	{
		IS_SLOT = 1,
		IS_GLOBAL = 2,
		IS_RANDOM = 4,
		IS_LEADER = 8,
		IS_ENEMY = 16,
		IS_BITFIELD = 32,
		IS_THROW_VICTIM = 64,
		IS_LAST_ATTACKER = 128,
		IS_MY_TEAMS_POINT_CHAR = 24,
		IS_HASH = 36,
		IS_MY_PARENT_SPRITE = 144
	}

	[Serializable]
	public struct SlotOrNum
	{
		public byte flags;

		public byte slotNum;

		public Fixed num;

		public bool HasFlag(Flags flag)
		{
			return false;
		}

		public void ApplyFlag(Flags flag)
		{
		}

		public void RemoveFlag(Flags flag)
		{
		}
	}

	[SerializeField]
	private SlotOrNum src1;

	[SerializeField]
	private SlotOrNum src2;

	[SerializeField]
	private SlotOrNum dest;

	[SerializeField]
	private bool isBoolean;

	[SerializeField]
	private SlotOpChain next;

	[SerializeField]
	private Operation operation;

	public static int RandomIntegerZeroToN(int n)
	{
		return 0;
	}

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void WriteToFile(BinaryWriter writer)
	{
	}

	public static bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool GetValueFor(SlotValueHolder me)
	{
		return false;
	}

	public void DoOperation(SlotValueHolder me)
	{
	}

	public bool IsArithmetic()
	{
		return false;
	}

	public bool IsBoolean()
	{
		return false;
	}

	public SlotOpChain GetNext()
	{
		return null;
	}

	public void SetNext(SlotOpChain next)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private void Reset(bool forceNewSlots = false)
	{
	}

	private bool GetValueFromSlot(ref SlotOrNum slot, SlotValueHolder me, ref Fixed value, bool alreadyDecided = false)
	{
		return false;
	}

	private bool GetDefaultValueFromSlot(ref SlotOrNum slot, SlotValueHolder me, ref Fixed value, bool alreadyDecided = false)
	{
		return false;
	}

	private bool PutValueInSlot(ref SlotOrNum slot, SlotValueHolder me, ref Fixed value, bool alreadyDecided = false)
	{
		return false;
	}

	private SlotValueHolder DecipherSVHFlagHelper(SlotValueHolder me, byte flags)
	{
		return null;
	}

	private bool SlotIsHash(ref SlotOrNum slot)
	{
		return false;
	}
}
