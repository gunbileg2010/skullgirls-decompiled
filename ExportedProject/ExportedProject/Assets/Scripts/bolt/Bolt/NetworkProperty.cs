using UdpKit;

namespace Bolt
{
	internal abstract class NetworkProperty
	{
		public int OffsetStorage;

		public int OffsetProperties;

		public int PropertyFilters;

		public int PropertyNameHash;

		public string PropertyName;

		public int PropertyPriority;

		public NetworkObj_Meta PropertyMeta;

		public bool ToProxies;

		public bool ToController;

		public PropertyInterpolationSettings Interpolation;

		public virtual bool AllowCallbacks => false;

		public virtual bool WantsOnRender => false;

		public virtual bool WantsOnSimulateAfter => false;

		public virtual bool WantsOnSimulateBefore => false;

		public virtual bool WantsOnControlGainedLost => false;

		public virtual bool WantsOnFrameCloned => false;

		public void Settings_Property(string name, int priority, int filters)
		{
		}

		public void Settings_Offsets(int properties, int storage)
		{
		}

		public void Settings_Interpolation(float snapMagnitude, bool enabled)
		{
		}

		public abstract bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet);

		public abstract void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet);

		public abstract void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, NetworkStorage other);

		public abstract bool Equals(NetworkObj obj, NetworkStorage storage1, NetworkStorage storage2);

		public virtual object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		public virtual int BitCount(NetworkObj obj)
		{
			return 0;
		}

		public virtual void SetDynamic(NetworkObj obj, object value)
		{
		}

		public virtual object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		public virtual bool SupportsDeltaCompression()
		{
			return false;
		}

		public virtual void OnInit(NetworkObj obj)
		{
		}

		public virtual void OnRender(NetworkObj obj)
		{
		}

		public virtual void OnSimulateBefore(NetworkObj obj)
		{
		}

		public virtual void OnSimulateAfter(NetworkObj obj)
		{
		}

		public virtual void OnParentChanged(NetworkObj obj, Entity newParent, Entity oldParent)
		{
		}

		public virtual void OnFrameCloned(NetworkObj obj, NetworkStorage storage)
		{
		}

		public virtual void OnControlGained(NetworkObj obj)
		{
		}

		public virtual void OnControlLost(NetworkObj obj)
		{
		}

		public virtual void SmoothCommandCorrection(NetworkObj obj, NetworkStorage from, NetworkStorage to, NetworkStorage storage, float t)
		{
		}
	}
}
