using UnityEngine;

public class FilmstripLootContainer : MonoBehaviour
{
	[SerializeField]
	private Transform lootContainer;

	[SerializeField]
	private CanvasGroup lootCanvasGroup;

	private EZAnimateFloat fadeAnimation;

	private LootType lootType;

	private GameObject rewardCardGO;

	public void PopulateLoot(Loot loot)
	{
	}

	public void Cleanup()
	{
	}

	public void FadeOut(float fadeOutTime = 0.25f, float delay = 0f)
	{
	}

	public void FadeIn(float fadeInTime = 0.25f, float delay = 0f)
	{
	}

	private void Fade(float fadeTo, float fadeTime, float delay)
	{
	}

	private void StopAnimation()
	{
	}
}
