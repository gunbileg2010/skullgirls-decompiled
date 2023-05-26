using System;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSettings : MonoBehaviour
{
	private const string kLastToSAgreedKey = "LastToSAgreedTo";

	private string minClientVersion;

	private int toSVersion;

	private bool haveSettings;

	private bool requestingSettings;

	private Action<bool> updateFromServerCallbacks;

	private void Start()
	{
	}

	public void UpdateFromServer(Action<bool> callback)
	{
	}

	public void InvalidateSettings()
	{
	}

	public bool NeedToShowToS()
	{
		return false;
	}

	public int GetLastToSVersionAgreedTo()
	{
		return 0;
	}

	public void RecordToSAgreement()
	{
	}

	public bool IsForcedUpdateRequired()
	{
		return false;
	}

	public static bool IsForcedUpdateRequired(string minVersion, string currentVersion)
	{
		return false;
	}

	private void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
