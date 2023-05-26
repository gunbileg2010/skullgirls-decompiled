using UnityEngine;
using UnityEngine.UI;

public class TallyText : MonoBehaviour
{
	[SerializeField]
	private float initialTallySpeed;

	[SerializeField]
	private float tallyTimeLimit;

	[SerializeField]
	private string numericFormatting;

	private Text _text;

	private float currentCount;

	private float targetCount;

	private float tallySpeed;

	private float tallyAcceleration;

	private Text text => null;

	private void Update()
	{
	}

	public void SetImmediate(float value)
	{
	}

	public void SetTargetTally(float targetValue)
	{
	}

	private void ChangeAcceleration(float target, float current)
	{
	}
}
