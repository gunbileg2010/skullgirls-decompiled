using UdpKit;
using UnityEngine;

namespace Bolt
{
	internal class NetworkProperty_Transform : NetworkProperty
	{
		private const int POSITION = 0;

		private const int ROTATION = 1;

		private const int VELOCITY = 2;

		private int PositionMask;

		private int RotationMask;

		private bool PositionEnabled;

		private bool RotationEnabled;

		private TransformSpaces Space;

		private PropertyExtrapolationSettings Extrapolation;

		internal PropertyQuaternionCompression RotationCompression;

		internal PropertyVectorCompressionSettings PositionCompression;

		public override bool AllowCallbacks => false;

		public override bool WantsOnRender => false;

		public override bool WantsOnSimulateAfter => false;

		public override bool WantsOnSimulateBefore => false;

		public void Settings_Space(TransformSpaces space)
		{
		}

		public void Settings_Vector(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		public void Settings_Quaternion(PropertyFloatCompressionSettings compression, bool strict)
		{
		}

		public void Settings_QuaternionEuler(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		public void Settings_Extrapolation(PropertyExtrapolationSettings extrapolation)
		{
		}

		private Vector3 GetPosition(Transform t)
		{
			return default(Vector3);
		}

		private void SetPosition(Transform t, Vector3 p)
		{
		}

		private void SetRotation(Transform t, Quaternion q)
		{
		}

		private Quaternion GetRotation(Transform t)
		{
			return default(Quaternion);
		}

		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		public override void OnInit(NetworkObj obj)
		{
		}

		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return false;
		}

		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, NetworkStorage other)
		{
		}

		public override bool Equals(NetworkObj obj, NetworkStorage storage1, NetworkStorage storage2)
		{
			return false;
		}

		public override bool SupportsDeltaCompression()
		{
			return false;
		}

		public override void OnRender(NetworkObj obj)
		{
		}

		public override void OnSimulateAfter(NetworkObj obj)
		{
		}

		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		public override void OnParentChanged(NetworkObj obj, Entity newParent, Entity oldParent)
		{
		}

		private Vector3 CalculateVelocity(NetworkTransform nt, Vector3 position)
		{
			return default(Vector3);
		}

		private void UpdateTransformValues(NetworkObj obj, Matrix4x4 l2w, Matrix4x4 w2l)
		{
		}
	}
}
