using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GraphicPulse : MonoBehaviour
{
	[SerializeField]
	private Color offColor;

	[SerializeField]
	private Color onColor;

	[SerializeField]
	private float period;

	private Graphic graphic;

	private float lerp;

	private Coroutine coroutine;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetPulse(bool value)
	{
	}

	private void StartPulse()
	{
	}

	private void StopPulse()
	{
	}

	private IEnumerator Pulse(bool loop)
	{
		return null;
	}
}
