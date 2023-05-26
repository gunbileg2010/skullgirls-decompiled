using UnityEngine;
using UnityEngine.UI;

public class DebugLogSection : MonoBehaviour
{
	[SerializeField]
	private Text messagePrototype;

	[SerializeField]
	private ScrollRect scrollRect;

	private const int kMaxMessages = 400;

	private const int kMaxMessageLength = 512;

	private const int kMaxStackTraceLength = 512;

	private Text[] messageTexts;

	private int nextMessageTextIndex;

	private bool forceShowOnError;

	private bool forceShowOnWarning;

	private bool showErrors;

	private bool showWarnings;

	private bool showInfo;

	private void OnEnable()
	{
	}

	public void EnableLog()
	{
	}

	public void DisableLog()
	{
	}

	public void SetForceShowLogOnError(bool forceShow)
	{
	}

	public void SetForceShowLogOnWarning(bool forceShow)
	{
	}

	public void UGUI_ToggleErrors(bool isOn)
	{
	}

	public void UGUI_ToggleWarnings(bool isOn)
	{
	}

	public void UGUI_ToggleInfo(bool isOn)
	{
	}

	public void UGUI_TestLogError()
	{
	}

	private bool IsErrorLogType(LogType logType)
	{
		return false;
	}

	private void OnLogMessageReceivedThreaded(string message, string stackTrace, LogType logType)
	{
	}

	private void OnLogMessageReceived(string message, string stackTrace, LogType logType)
	{
	}
}
