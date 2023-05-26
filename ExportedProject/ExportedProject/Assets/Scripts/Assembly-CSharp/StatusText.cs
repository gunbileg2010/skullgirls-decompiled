using UnityEngine;
using UnityEngine.UI;

public class StatusText : MonoBehaviour
{
	[SerializeField]
	private int lineCount;

	[SerializeField]
	private float lineLifetime;

	private Text[] texts;

	private UIGradient32[] textGradients;

	private float[] lifetimes;

	private bool[] ignoreClearRequests;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void AddStatusText(string text, Gradient textGradient = null, bool ignoreClear = false)
	{
	}

	public bool HasStatusText(string text)
	{
		return false;
	}

	public void ClearStatusText()
	{
	}

	private void Init()
	{
	}
}
