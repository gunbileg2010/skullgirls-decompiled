using System;
using UnityEngine;

namespace Bolt
{
	[Documentation]
	public class NetworkTransform
	{
		internal int PropertyIndex;

		internal Transform Render;

		internal Transform Simulate;

		internal bool SkipInterpolation;

		internal Func<BoltEntity, Vector3, Vector3> Clamper;

		internal DoubleBuffer<Vector3> RenderDoubleBufferPosition;

		internal DoubleBuffer<Quaternion> RenderDoubleBufferRotation;

		internal TransformSpaces space;

		public Transform Transform => null;

		public bool Teleport => false;

		public Vector3 Position => default(Vector3);

		public Quaternion Rotation => default(Quaternion);

		internal NetworkTransform()
		{
		}

		internal NetworkTransform(TransformSpaces space)
		{
		}

		public void SetExtrapolationClamper(Func<BoltEntity, Vector3, Vector3> clamper)
		{
		}

		[Obsolete]
		public void SetTransforms(Transform simulate)
		{
		}

		[Obsolete]
		public void SetTransforms(Transform simulate, Transform render)
		{
		}

		public void ChangeTransforms(Transform simulate)
		{
		}

		public void ChangeTransforms(Transform simulate, Transform render)
		{
		}

		internal void SetTeleportInternal(bool teleport)
		{
		}

		internal void SetTransformsInternal(Transform simulate, Transform render)
		{
		}
	}
}
