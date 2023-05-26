using UnityEngine;
using UnityEngine.UI;

public class ProfileTopFighterView : MonoBehaviour
{
	[SerializeField]
	private RectTransform characterPortaitHolder;

	[SerializeField]
	private Image characterSigil;

	private CharacterPortrait characterPortrait;

	private Character character;

	public void Populate(BaseCharacterData baseData, Character character = null)
	{
	}

	public void Cleanup()
	{
	}

	public void UGUI_TopFighterPressed()
	{
	}
}
