using System;
using System.Collections.Generic;
using UnityEngine;

public class GachaUniqueRoboFaceScreen : MonoBehaviour
{
	private enum AnimState
	{
		Idle = 0,
		Hold = 1
	}

	[Serializable]
	public class FaceData
	{
		public GameObject face;

		public float minShowTime;

		public float maxShowTime;

		public float weight;
	}

	[SerializeField]
	private List<FaceData> faceDatas;

	[SerializeField]
	private int openingAnimFaceIndex;

	[SerializeField]
	private AnimationCurve faceBlinkAnimCurve;

	[SerializeField]
	private Transform faceParent;

	private Gacha3D gacha3d;

	private AnimState animState;

	private int currentFaceIndex;

	private int targetFaceIndex;

	private float animationPercent;

	private float stickTime;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void SelectFace(int overrideFace = -1)
	{
	}

	private void RefreshFace(int index)
	{
	}

	private void OnStartIntro()
	{
	}

	private void OnStopIntro()
	{
	}

	private void OnStartOpening()
	{
	}

	private void OnStopOpening()
	{
	}
}
