using System.Collections.Generic;
using UnityEngine;

public class BoltConsole : MonoBehaviour
{
	internal struct Line
	{
		public Color color;

		public string text;
	}

	private static int _changed;

	private static readonly object _mutex;

	private static readonly BoltRingBuffer<Line> _lines;

	private static readonly BoltRingBuffer<Line> _linesRender;

	public float scrollIndex;

	private static bool _debugToggle;

	private static bool _infoToggle;

	private static bool _warnToggle;

	[SerializeField]
	private float consoleHeight;

	[SerializeField]
	private int lineHeight;

	[SerializeField]
	public bool visible;

	[SerializeField]
	internal KeyCode toggleKey;

	[SerializeField]
	private int padding;

	[SerializeField]
	private int fontSize;

	[SerializeField]
	private int inset;

	private int sizeAdjustment;

	private bool init;

	internal static int LinesCount => 0;

	internal static IEnumerable<Line> Lines => null;

	public static void Write(string line, Color color)
	{
	}

	public static void Write(string line)
	{
	}

	internal static void WriteReal(string line, Color color)
	{
	}

	private void Awake()
	{
	}

	internal static void Clear()
	{
	}

	internal static void LinesRefresh()
	{
	}

	private void OnGUI()
	{
	}

	private Rect GetRect(int line)
	{
		return default(Rect);
	}
}
