using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
	[SerializeField]
	private List<AchievementGraph> achievementGraphs;

	private Dictionary<string, AchievementData> achievementDatasByGuid;

	private Dictionary<string, Achievement> achievementsByGuid;

	private bool didInitialGet;

	private int notifCount;

	public event Action AchievementsUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public List<AchievementGraph> GetAchievementGraphs()
	{
		return null;
	}

	public AchievementData GetAchievementDataByGuid(string guid)
	{
		return null;
	}

	public Achievement GetAchievementByGuid(string guid)
	{
		return null;
	}

	public bool HasAchievementsFromServer()
	{
		return false;
	}

	public void GetAchievementsFromServer(Action<bool> callback)
	{
	}

	public void ClaimAchievement(Achievement achievement, Action<bool> callback = null)
	{
	}

	public int GetAchievementNotifCount()
	{
		return 0;
	}

	private void RefreshGraphStates(bool markToasts = false)
	{
	}

	private void OnLoggedIn(AuthenticateRequest authenticateRequest)
	{
	}

	private void OnResponseDictionaryReceived(Dictionary<string, object> responseDictionary)
	{
	}
}
