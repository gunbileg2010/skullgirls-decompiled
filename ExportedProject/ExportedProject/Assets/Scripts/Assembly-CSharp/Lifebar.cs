using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
	[SerializeField]
	private Slider lifebar;

	[SerializeField]
	private Image lifebarFrameTop;

	[SerializeField]
	private Image lifebarFrameBottom;

	[SerializeField]
	private Image lifebarSlash;

	[SerializeField]
	private Image lifebarTick;

	[SerializeField]
	private SpriteNumDisplayUI percentageUI;

	[SerializeField]
	private Slider redLifebar;

	[SerializeField]
	private GameObject redlifeTick;

	[SerializeField]
	private Slider lostLifebar;

	[SerializeField]
	private float lostLifeDrainRate;

	[SerializeField]
	private Slider barrierLifebar;

	[SerializeField]
	private Image barrierLifebarTick;

	[SerializeField]
	private Image barrierLifebarSlash;

	[SerializeField]
	private float lostLifeToSpawnBit;

	[SerializeField]
	private LifebarBit lifebarBitPrefab;

	[SerializeField]
	private float slashMaxPercent;

	[SerializeField]
	private float slashAlphaDelay;

	[SerializeField]
	private float slashAlphaRate;

	[SerializeField]
	private float lifebarBaseOffset;

	private int lastLife;

	private int lastRedlife;

	private float lastBarrierLife;

	private Actor actor;

	private float slashAlphaDelayTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void AlphaOutLifebarSlash(Image slash)
	{
	}

	private void PulseLifebarSlash(Image slash, float lifebarValue)
	{
	}

	private void HideBarrierLifebarElements()
	{
	}

	public void SetLife(int life, int maxLife, int redlife, bool animateSlash = true)
	{
	}

	public void SetVisible(bool lifebarVisible, bool redLifebarVisible, bool lostLifebarVisible)
	{
	}

	public void SetActor(Actor newActor)
	{
	}

	public void ToggleHealthPercent()
	{
	}
}
