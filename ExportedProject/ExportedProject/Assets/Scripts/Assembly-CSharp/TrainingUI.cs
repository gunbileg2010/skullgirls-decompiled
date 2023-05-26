using System.Collections.Generic;
using UnityEngine;

public static class TrainingUI
{
	private struct FrameData
	{
		public Color32 attackBoxColor;

		public Color32 hitBoxColor;

		public Color32 cancelOKColor;

		public Color32 extentColor;

		public int frameNumber;
	}

	private const int kMaxFrameDataKept = 175;

	private const int kFrameDataBarYPos = 3;

	private const int kFrameDataRows = 4;

	private const int kDotSize = 10;

	private const int kColumnSpacing = 4;

	private const int kRowSpacing = 4;

	private const int kFrameDataBarHeight = 60;

	private const int kFrameDataCursorWidth = 10;

	private static int numFramesAttackerInNeutral;

	private static int numFramesDefenderInNeutral;

	private static bool isAttackStartup;

	private static int numFramesAttackStartup;

	private static bool attackerWasInNeutral;

	private static bool defenderWasInNeutral;

	private static bool lastHitWasFromCurrentPointChar;

	private static bool lastFrameAttackerHitPause;

	private static int plusMinusFramesLeftToDisplay;

	private static List<FrameData> prevFrameDatas;

	public static void UpdateFrameData(Actor attacker, Actor defender)
	{
	}

	public static void DrawFrameData()
	{
	}
}
