using UnityEngine;
using UnityEngine.UI;

public class ComboCounter : MonoBehaviour
{
	[SerializeField]
	private Text comboCountText;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private GameObject comboCounterDisplay;

	[SerializeField]
	private Animation displayAnimation;

	[SerializeField]
	private Gradient trueComboGradient;

	[SerializeField]
	private Gradient comboGradient;

	private const int kMaxComboCount = 98;

	private const int kMinComboCount = 2;

	private Actor actor;

	private bool anim;

	private bool trueCombo;

	private UIGradient32 textGradient;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetActor(Actor inActor)
	{
	}

	public void SetTrueCombo(bool isTrueCombo)
	{
	}

	private string GetComboDescription(int count)
	{
		return null;
	}

	private void ToggleDisplay(bool shouldDisplay)
	{
	}
}
