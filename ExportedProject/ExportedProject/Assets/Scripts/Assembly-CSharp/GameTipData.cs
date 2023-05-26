using UnityEngine;

[CreateAssetMenu]
public class GameTipData : ScriptableObject
{
	[SerializeField]
	private string descriptionLocKey;

	[SerializeField]
	private Sprite icon;

	[SerializeField]
	private Sprite iconFrame;

	public string GetDescriptionKey()
	{
		return null;
	}

	public Sprite GetIcon()
	{
		return null;
	}

	public Sprite GetIconFrame()
	{
		return null;
	}
}
