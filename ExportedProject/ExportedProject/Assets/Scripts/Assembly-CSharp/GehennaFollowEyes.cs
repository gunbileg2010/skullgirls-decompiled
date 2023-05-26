using UnityEngine;

public class GehennaFollowEyes : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer meshRend;

	[SerializeField]
	private SkinnedMeshRenderer skinnedMeshRend;

	[SerializeField]
	private Transform positionSampleOverride;

	[SerializeField]
	private Vector2 minMaxLeftRightTextureOffset;

	[SerializeField]
	private float maxXDeltaDistanceToTrack;

	[SerializeField]
	private Vector2 minMaxUpDownTextureOffset;

	[SerializeField]
	private float maxYDeltaDistanceToTrack;

	[SerializeField]
	private Vector2 twitchMaxRange;

	private MaterialPropertyBlock matPropBlock;

	private void OnDrawGizmosSelected()
	{
	}

	private void Update()
	{
	}
}
