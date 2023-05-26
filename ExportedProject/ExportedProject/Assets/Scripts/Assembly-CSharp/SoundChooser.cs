using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SoundChooser
{
	public enum ChannelType : byte
	{
		SFX = 0,
		VO = 1,
		VO2 = 2,
		NO_CHANNEL = 3,
		VO_NOCUTOFF = 4,
		SFX_NOCUTOFF = 5,
		VO2_NOCUTOFF = 6
	}

	public class Selection
	{
		public HashAppend meEvent;

		public HashAppend parentEvent;

		public HashAppend enemyEvent;

		public HashAppend pointEvent;

		public HashAppend childEvent;

		public float weight;

		public bool isGlobal;

		public ChannelType channelType;

		public sbyte setSoundSlot;

		public List<ushort> soundIndices;

		public List<Selection> playAlso;

		public void ReadFromFile(BinaryReader reader)
		{
		}

		public void Clear()
		{
		}

		public bool IsVO()
		{
			return false;
		}
	}

	private SlotOpChain preconditions;

	private List<Selection> selections;

	private bool doNotInterruptMyself;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}

	public Selection ChooseSelection(SlotValueHolder svh)
	{
		return null;
	}

	public bool WouldBeInterruptingMyself(AudioClip soundToCheck, List<AudioClip> sfxList)
	{
		return false;
	}

	public bool DoNotInterruptMyself()
	{
		return false;
	}
}
