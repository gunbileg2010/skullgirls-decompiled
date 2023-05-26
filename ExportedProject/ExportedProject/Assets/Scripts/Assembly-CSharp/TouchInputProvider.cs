using HVS;
using UnityEngine;

public class TouchInputProvider : InputProvider
{
	public enum TouchRestrictions
	{
		Unrestricted = 0,
		RestrictAll = 1,
		RestrictToZone = 2
	}

	private bool didSwipe;

	private Vector4 inputBounds;

	private TouchRestrictions inputRestrictions;

	private bool ignoreSustainedInput;

	private int doubleSwipeState;

	private ZInput tapInput;

	private ZInput swipeInput;

	public override void Enable()
	{
	}

	public override void Disable()
	{
	}

	public override ZInput GetInput()
	{
		return null;
	}

	public override void EndSustainedInput()
	{
	}

	public void SetInputZoneBounds(Vector4 inputBounds, TouchRestrictions inputRestrictions = TouchRestrictions.Unrestricted)
	{
	}

	private void OnTapInput(TouchInfo touchInfo)
	{
	}

	private void OnTouchInput(TouchInfo touchInfo)
	{
	}

	private bool IsOutOfBounds(TouchInfo touchInfo)
	{
		return false;
	}
}
