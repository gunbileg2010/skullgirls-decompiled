using UnityEngine;
using UnityEngine.UI;

public class SpriteFrameSetBySlider : MonoBehaviour
{
	[SerializeField]
	private Sprite[] sprites;

	public float percentSlider;

	private Image image;

	private float lastSeenPercent;

	private void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void Update()
	{
	}
}
