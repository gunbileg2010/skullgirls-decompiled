using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
	[SerializeField]
	private AudioClip intro;

	[SerializeField]
	private AudioClip loop;

	[SerializeField]
	private bool alwaysPlayIntroFirstTime;

	[SerializeField]
	private float chanceToPlayIntro;

	[SerializeField]
	private bool randomizeLoopStartTime;

	[SerializeField]
	private float[] randomizedLoopTimes;

	private static List<string> playedBeforeNames;

	private void Start()
	{
	}
}
