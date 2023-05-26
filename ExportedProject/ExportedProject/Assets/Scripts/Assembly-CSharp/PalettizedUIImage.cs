using UnityEngine;
using UnityEngine.UI;

public class PalettizedUIImage : MonoBehaviour
{
	[SerializeField]
	private bool assignRenderQueueOnImageSet;

	[SerializeField]
	private GameObject loadingGo;

	private static Material palettizedUIMaterial;

	private static int _PaletteTex;

	private static int _Grayscale;

	private int lastPlayerNumber;

	private int lastInTeamIndex;

	private int lastPalettteIconOptionSet;

	private static float kUIChowderSquareSizeOverride;

	private Image _image;

	private PalettizedImage palettizedImage;

	private int cachedPaletteIndex;

	private Palette cachedPalette;

	private Material imageCachedMaterial;

	public Image image => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetImage(PalettizedImage palettizedImage, Palette palette, int paletteIndex, Actor actor = null, int playerNumber = 1, int inTeamIndex = 0, int optionSetOverride = 0)
	{
	}

	public void ClearImage()
	{
	}

	public void SetColor(Color color)
	{
	}

	public void SetGrayscaleAmount(float amount)
	{
	}

	private void SetImageSprite(Sprite sprite)
	{
	}
}
