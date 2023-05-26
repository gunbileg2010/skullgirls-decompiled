using UnityEngine;

public class PanNewMeridianSequentialAction : SequentialAction
{
	[SerializeField]
	private bool useCurrentPosition;

	[SerializeField]
	private float to;

	[SerializeField]
	private float from;

	[SerializeField]
	private float duration;

	[SerializeField]
	private Zone targetZone;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
