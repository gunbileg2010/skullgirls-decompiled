using System.Collections.Generic;
using UnityEngine;

public class NotificationsManager : MonoBehaviour
{
	[SerializeField]
	private int daysToPresentEvents;

	[SerializeField]
	private int hoursAfterRiftSeasonNotification;

	private const string kNotificationTitle = "Skullgirls";

	private void Start()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static List<LTAEventServerData> ScheduleLTAEventNotifications(List<LTAEventServerData> futureEventServerDatas, List<LTAEventData> scriptableObjectEventDatas, int numDaysInFuture)
	{
		return null;
	}

	private void ScheduleAllNotifications()
	{
	}

	private void ScheduleEnergyNotification()
	{
	}

	private void ScheduleGachaNotifications()
	{
	}

	private void ScheduleOfferNotifications()
	{
	}

	private bool ScheduleSingleOfferNotifs(OfferServerData offerToSchedule)
	{
		return false;
	}

	private void GetAndScheduleLTAEventNotifications()
	{
	}

	private void ScheduleRiftBattleNotifications()
	{
	}

	private void ScheduleDeploymentNotifications()
	{
	}
}
