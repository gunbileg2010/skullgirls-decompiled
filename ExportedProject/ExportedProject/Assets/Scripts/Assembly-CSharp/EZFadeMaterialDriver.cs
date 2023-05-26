using UnityEngine;

public class EZFadeMaterialDriver : EZAnimationDriver
{
	[SerializeField]
	private Material material;

	[SerializeField]
	private Color fromColor;

	[SerializeField]
	private Color toColor;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}
}
