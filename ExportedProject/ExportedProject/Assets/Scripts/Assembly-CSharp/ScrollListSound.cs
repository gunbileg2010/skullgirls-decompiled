using UnityEngine;
using UnityEngine.UI;

public class ScrollListSound : MonoBehaviour
{
	[SerializeField]
	private AudioClip audioClip;

	[SerializeField]
	private float playClipAfterMovementAmount;

	private ScrollRect scrollRect;

	private RectTransform scrollRectContentTransform;

	private float lastTickPosition;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
