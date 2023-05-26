using UnityEngine;

public class ScaleWithOtherElement : MonoBehaviour
{
	public enum TrackMode
	{
		Off = 0,
		FollowOwn = 1,
		MatchOther = 2
	}

	[SerializeField]
	private RectTransform target;

	[SerializeField]
	private Vector3 baseLocalScale;

	[SerializeField]
	private Vector2 basePixelSize;

	[SerializeField]
	private TrackMode xTrackMode;

	[SerializeField]
	private TrackMode yTrackMode;

	private Vector2 lastSize;

	private void OnEnable()
	{
	}

	public void Update()
	{
	}
}
