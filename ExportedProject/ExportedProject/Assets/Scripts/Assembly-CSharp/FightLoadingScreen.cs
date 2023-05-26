using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightLoadingScreen : MonoBehaviour
{
	[SerializeField]
	private RawImage characterArtImage;

	[SerializeField]
	private LocalizedUGUIText hintText;

	[SerializeField]
	private float characterChangeTime;

	[TextArea]
	public string[] hints;

	private List<BaseCharacterData> cycleCharacters;

	private int characterIndex;

	private float cycleTimer;

	private void Update()
	{
	}

	public void Show(string hint, List<BaseCharacterData> cycleCharacterDatas)
	{
	}

	public void Hide()
	{
	}

	private void CycleCharacter()
	{
	}
}
