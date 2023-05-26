using UnityEngine;
using UnityEngine.UI;

public class AlphaMaskImage : MonoBehaviour
{
	[SerializeField]
	private bool assignRenderQueueOnImageSet;

	private static Material alphaMaskMaterial;

	private static int _AlphaMask;

	private static int _Alpha;

	private Image _image;

	private Image image => null;

	public void SetImage(Sprite colorSprite, Texture2D alphaMask, float alpha = 1f)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public float GetAlpha()
	{
		return 0f;
	}

	public void ClearImage()
	{
	}
}
