using System;
using System.Collections.Generic;
using UnityEngine;

public class StageSkinnedMeshExportHelper : MonoBehaviour
{
	[Serializable]
	public class SkinnedAnim
	{
		public AnimationClip animClip;

		public string stateName;

		public int animationControllerLayerIndex;

		public float speedMult;
	}

	[NonSerialized]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	public UVFrameSetByAnimator uvFramesSetByAnimator;

	public List<SkinnedAnim> skinnedAnims;

	public bool transformRootJointToStagePos;

	public bool breakdownBoneTree;

	public bool forceUVStepping;

	public string sharedAnimFileName;

	private void Awake()
	{
	}
}
