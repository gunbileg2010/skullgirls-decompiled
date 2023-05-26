using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SoundEffect
{
	public struct PlayParams
	{
		public int channel;

		public int volume;

		public int pan;

		public Actor callingActor;

		public List<AudioClip> sfxList;

		public uint meEvent;

		public uint parentEvent;

		public uint enemyEvent;

		public uint pointEvent;

		public uint childEvent;

		public PlayParams(int channel)
		{
		}

		public bool HasEvents()
		{
			return false;
		}
	}

	public class ChannelInfo
	{
		public Queue<AudioClip> queuedToPlay;

		public Action queueEndCallback;

		public Actor ownerActor;

		private Coroutine audioCoroutine;

		public void Reset()
		{
		}

		public void Start(float volume = 1f)
		{
		}

		public void Stop()
		{
		}

		public void PurgeQueue()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		private IEnumerator DoPlayAudio(float volume = 1f)
		{
			return null;
		}
	}

	private const int kNumGlobalVoices = 20;

	private const int kNumGlobalSteroVoices = 8;

	private const int kNumPointCharVoices = 6;

	private const int kNumNonPointCharVoices = 10;

	private const int kNumLocalVoices = 16;

	private static List<ChannelInfo> globalChannels;

	private static List<ChannelInfo> globalStereoChannels;

	private static List<ChannelInfo> localSfxChannels;

	private static List<ChannelInfo> localVoChannels;

	private static int nextGlobalStereoChannel;

	private static int nextGlobalChannel;

	private static int nextLocalChannel;

	private uint triggerEvent;

	private List<SoundChooser> choosers;

	static SoundEffect()
	{
	}

	public static int GetCharacterChannel(int index)
	{
		return 0;
	}

	public static int GetNextLocalChannel()
	{
		return 0;
	}

	public static bool IsPlayingVO(int voChannelIndex)
	{
		return false;
	}

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}

	public void Play(ref PlayParams playParams)
	{
	}

	public uint GetTriggerEvent()
	{
		return 0u;
	}

	private bool InternalPlay(SoundChooser.Selection playSelection, ref PlayParams playParams, bool makeEvents, SoundChooser chooser)
	{
		return false;
	}
}
