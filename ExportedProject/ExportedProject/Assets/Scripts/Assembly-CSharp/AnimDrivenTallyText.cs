using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class AnimDrivenTallyText : MonoBehaviour
{
	public float tallyPercent;

	[SerializeField]
	private float startValue;

	[SerializeField]
	private float endValue;

	[SerializeField]
	private string prefix;

	[SerializeField]
	private SpriteNumDisplayUI spriteNumber;

	[SerializeField]
	private string numericFormatting;

	private Text _text;

	private float lastCalcValue;

	private Text text => null;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SetValues(float start, float end, float percent)
	{
	}

	public float GetEndValue()
	{
		return 0f;
	}

	public float GetStartValue()
	{
		return 0f;
	}

	public void SetGradient(Color32 topColor, Color32 bottomColor)
	{
	}

	public void SetGradient(Gradient gradient)
	{
	}

	public float GetLastValue()
	{
		return 0f;
	}

	private void PopulateText()
	{
	}
}
