using UnityEngine;

public class AnimatorRandomizeStartPosition : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private string stateName;

	[SerializeField]
	private int layerIndex;

	[SerializeField]
	private bool randomizeOnEnable;

	[SerializeField]
	private float[] normalizedStartPositions;

	private void OnEnable()
	{
	}

	public void PlayAtRandomStart(float? overrideStartPos = null)
	{
	}
}
