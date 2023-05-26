using UnityEngine;
using UnityEngine.UI;

public class UIShinyEffect : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem[] shinyParticleSystems;

	[SerializeField]
	private GameObject bgPulseParent;

	[SerializeField]
	private Image bgPulse;

	[SerializeField]
	private ParticleSystem rewardBurstParticleSystem;

	public void Populate(Character character)
	{
	}

	public void Populate(bool onOff, Element element)
	{
	}

	public void PlayRewardBurst(Character character)
	{
	}

	public void PlayRewardBurst(Element element)
	{
	}

	private void ChangeParticleSystemColor(ParticleSystem particleSystem, Color particleColor)
	{
	}
}
