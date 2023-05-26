using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ActorData
{
	private static Dictionary<string, List<string>> sfxAssetPaths;

	private string dataName;

	private PersistentActorData persistentActorData;

	private List<AniFrame> frames;

	private List<ActorState> states;

	private ActorState startState;

	private ActorState thrownState;

	private Bounds defaultBounds;

	private SlotValueHolder svh;

	private ActorLayer defaultDisplayLayer;

	private byte maxTransitionsFromAState;

	private ushort maxMotionLength;

	private bool hasShadow;

	private bool onlyRenderShadow;

	private List<ActorData> projectileDatas;

	private ActorData parentData;

	private byte[][] artMemoryRefs;

	private int[] artMemoryOffsets;

	private bool sfxLoaded;

	private Dictionary<uint, SoundEffect> sfxMap;

	private List<AudioClip> sfxList;

	private byte refCount;

	public void ReadFromFile(string dataName, BinaryReader reader, uint offset, List<AniFrame> afList = null)
	{
	}

	public void Clear()
	{
	}

	public void LoadSfx()
	{
	}

	public void UnloadSfx(bool forceUnloadHitspark = false)
	{
	}

	public string GetDataName()
	{
		return null;
	}

	public Palette GetPalette()
	{
		return null;
	}

	public Bounds GetDefaultBounds()
	{
		return default(Bounds);
	}

	public ActorLayer GetDefaultDisplayLayer()
	{
		return default(ActorLayer);
	}

	public int GetFrameCount()
	{
		return 0;
	}

	public ActorState GetStartState()
	{
		return null;
	}

	public ActorState GetThrownState()
	{
		return null;
	}

	public ActorState GetStateByIndex(int index)
	{
		return null;
	}

	public bool HasShadow(Actor actor)
	{
		return false;
	}

	public bool HasOnlyShadow()
	{
		return false;
	}

	public SlotValueHolder GetSVH()
	{
		return null;
	}

	public ushort GetMaxMotionLength()
	{
		return 0;
	}

	public byte GetMaxTransitionsFromAState()
	{
		return 0;
	}

	public List<AniFrame> GetAniFrames()
	{
		return null;
	}

	public List<ActorData> GetProjectileDatas()
	{
		return null;
	}

	public Dictionary<uint, SoundEffect> GetSfxMap()
	{
		return null;
	}

	public List<AudioClip> GetSfxList()
	{
		return null;
	}

	public ActorData GetParentData()
	{
		return null;
	}

	public ActorData GetRootData()
	{
		return null;
	}

	public void SetArtMemory(ArtMemoryType type, byte[] artMemRef, int offset)
	{
	}

	public byte[] GetArtMemory(ArtMemoryType type)
	{
		return null;
	}

	public int GetArtMemoryOffset(ArtMemoryType type)
	{
		return 0;
	}

	public static AudioClip LoadAudioClip(string assetPath, bool wantJapanese)
	{
		return null;
	}

	public void AddRef()
	{
	}

	public void RemoveRef()
	{
	}

	public byte GetRefCount()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	private void DetermineMaxTransitionsFromAState()
	{
	}

	private bool ReadFromFileInternal(string dataName, BinaryReader reader, uint offset = 0u, List<AniFrame> afList = null)
	{
		return false;
	}
}
