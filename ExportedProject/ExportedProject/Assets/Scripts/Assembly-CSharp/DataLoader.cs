using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public static class DataLoader
{
	private class LoadActorDataState
	{
		public string dataName;

		public Action<ActorData> callback;

		public LoadActorDataState(string dataNameArg, Action<ActorData> callbackArg)
		{
		}
	}

	private class LoadActorArtState
	{
		public string dataName;

		public PlayerNumber playerNumber;

		public Action callback;

		public LoadActorArtState(string dataName, PlayerNumber playerNumber, Action callback)
		{
		}
	}

	private struct ArtMemStat
	{
		public string name;

		public int size;
	}

	private static bool initialized;

	private static Dictionary<string, PersistentActorData> persistentActorDatas;

	private static Dictionary<string, ActorData> actorDatas;

	private static Dictionary<string, int> alwaysLoadedArtMemoryOffsets;

	private static int memPosAlways;

	private static string loadedPointArtLeft;

	private static string loadedPointArtRight;

	private static bool p1PointArtOnLeft;

	private static bool p2PointArtOnRight;

	private static string dataAssetPath;

	private static Dictionary<string, LoadActorDataState> loadActorDatasInProgress;

	private static WaitCallback loadPointArtCallback;

	private static Dictionary<string, LoadActorArtState> loadPointArtsInProgress;

	private static List<string> actorDatasToRecycle;

	public static void Init(int residentArtMemorySize, int pointArtMemorySize)
	{
	}

	public static void Reset()
	{
	}

	public static void ClearActorArtMemory()
	{
	}

	public static void ClearActorDatas()
	{
	}

	public static PersistentActorData GetPersistentActorData(string dataName)
	{
		return null;
	}

	public static void LoadResidentArtForActor(string dataName)
	{
	}

	public static bool IsResidentArtMemoryAtLimit()
	{
		return false;
	}

	public static bool IsResidentArtLoadedForActor(string dataName)
	{
		return false;
	}

	public static void LoadPointArtForActor(string characterName, PlayerNumber playerNumber)
	{
	}

	public static void LoadPointArtForActorAsync(string characterName, PlayerNumber playerNumber, Action callback)
	{
	}

	public static ActorData LoadActorData(string characterName)
	{
		return null;
	}

	public static void LoadActorDataAsync(string characterName, Action<ActorData> loadedCallback)
	{
	}

	public static void LoadCharacterBlobData(string filename)
	{
	}

	public static bool IsPointArtLoadedForActor(PlayerNumber playerNumber, string actorDataName)
	{
		return false;
	}

	private static void ReadCharacterBlob(string filename, List<ArtMemStat> residentStats = null, List<ArtMemStat> pointStats = null, bool analysisOnly = false)
	{
	}

	private static Stream GetAssetStream(string relativeAssetPath)
	{
		return null;
	}

	private static void LoadActorDataThread(object context)
	{
	}

	private static void LoadPointArtThread(object context)
	{
	}

	private static void ClearPointArt()
	{
	}

	private static void OnStateChanged(string fromState, string toState)
	{
	}

	private static bool InternalIsPointArtLoadedAndUpdateSlotIndicators(PlayerNumber playerNumber, string characterName)
	{
		return false;
	}
}
