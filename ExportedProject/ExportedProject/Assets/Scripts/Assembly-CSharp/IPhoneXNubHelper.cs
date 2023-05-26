using System.Collections.Generic;
using UnityEngine;

public class IPhoneXNubHelper : MonoBehaviour
{
	[SerializeField]
	private float nubOffset;

	[SerializeField]
	private List<RectTransform> excludedTransforms;

	[SerializeField]
	private GameObject pillarBoxGO;

	[SerializeField]
	private bool debug;

	private void Awake()
	{
	}

	private void SetRectTransformOffsets(RectTransform trans, float left, float right)
	{
	}
}
