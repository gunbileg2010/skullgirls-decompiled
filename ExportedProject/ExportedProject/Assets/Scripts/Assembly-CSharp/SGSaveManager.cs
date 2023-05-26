using UnityEngine;

public class SGSaveManager : MonoBehaviour
{
	private SGSaveFile saveFile;

	private const string kSaveFileName = "save.txt";

	private const string kProfileFileName = "prof.sgm";

	private const string kLegacyGameDefinitionKey = "gameDefinition";

	private void Awake()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static void ClearAllSaveData()
	{
	}

	public void Save()
	{
	}

	public void Load()
	{
	}

	public bool GetBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public void SetBool(string key, bool value)
	{
	}

	public string GetString(string key, string defaultValue = null)
	{
		return null;
	}

	public void SetString(string key, string value)
	{
	}

	public int GetInt(string key, int defaultValue = 0)
	{
		return 0;
	}

	public void SetInt(string key, int value)
	{
	}

	public void SetLong(string key, long value)
	{
	}

	public long GetLong(string key, long defaultValue = 0L)
	{
		return 0L;
	}

	public T LoadSerializable<T>(string fileName) where T : class
	{
		return null;
	}

	public void SaveSerializable<T>(string fileName, T serializable) where T : class
	{
	}

	private static void ClearSaveFile()
	{
	}

	private static void ClearProfileData()
	{
	}

	private static void ClearOfflineSaveData()
	{
	}

	private static void ClearPlayerPrefs()
	{
	}
}
