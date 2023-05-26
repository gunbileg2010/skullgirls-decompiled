using UnityEngine;
using UnityEngine.UI;

public class Badge : MonoBehaviour
{
	public const int kExclaimNumber = -1;

	[SerializeField]
	private Text numberText;

	[SerializeField]
	private int initialNumber;

	[SerializeField]
	private int maxNumber;

	[SerializeField]
	private Button associatedButton;

	[SerializeField]
	private bool resetNumberOnButtonClick;

	private int number;

	private bool hasBeenSet;

	private void Awake()
	{
	}

	public void SetNumber(int newNumber)
	{
	}

	public void IncreaseNumber(int amount)
	{
	}

	public void DecreaseNumber(int amount)
	{
	}

	public void Clear()
	{
	}

	public int GetNumber()
	{
		return 0;
	}

	private void OnButtonClicked()
	{
	}
}
