using UnityEngine;

public class PalettizedImage : ScriptableObject
{
	[SerializeField]
	private DynamicResource dynamicSprite;

	public Sprite TakeSprite()
	{
		return null;
	}

	public void ReturnSprite()
	{
	}

	public bool Valid()
	{
		return false;
	}
}
