using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GachaManager : MonoBehaviour
{
	[SerializeField]
	private List<GachaData> reels;

	[SerializeField]
	private GachaData tutorialReel;

	[SerializeField]
	private GachaData defaultHighlightedGacha;

	private const string kHourlyGachaId = "1";

	private const string kDailyGachaId = "2";

	private List<GachaServerData> availableForPurchaseGachas;

	private static readonly string[] shardGachas;

	public event Action AvailableGachasUpdated
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

	private void Start()
	{
	}

	public List<GachaData> GetAllGachas()
	{
		return null;
	}

	public GachaData GetTutorialGacha()
	{
		return null;
	}

	public GachaData GetGachaByGuid(string guid)
	{
		return null;
	}

	public int GetAvailableGachaCount()
	{
		return 0;
	}

	public bool CanClaimHourlyGacha()
	{
		return false;
	}

	public bool CanClaimDailyGacha()
	{
		return false;
	}

	public int GetClaimableShardGachasCount(string gachaGuid)
	{
		return 0;
	}

	public DateTime GetHourlyGachaClaimTime()
	{
		return default(DateTime);
	}

	public DateTime GetDailyGachaClaimTime()
	{
		return default(DateTime);
	}

	public GachaData GetHighlightedGacha()
	{
		return null;
	}

	public void RefreshAvailableGachasFromServer(Action<GetAvailableGachasRequest> callback)
	{
	}

	public List<GachaServerData> GetGachasAvailableForPurchase()
	{
		return null;
	}

	private GachaServerData GetGachaServerDataById(string targetGuid)
	{
		return null;
	}

	private void OnLoggedIn(AuthenticateRequest authRequest)
	{
	}
}
