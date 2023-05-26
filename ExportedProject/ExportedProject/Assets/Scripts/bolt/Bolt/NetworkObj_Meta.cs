using System.Collections.Generic;

namespace Bolt
{
	internal abstract class NetworkObj_Meta
	{
		internal struct Offsets
		{
			internal int OffsetStorage;

			internal int OffsetObjects;

			internal int OffsetProperties;

			internal Offsets(int properties, int storage, int objects)
			{
			}
		}

		private static readonly int[] ZeroIndices;

		private static readonly string[] ZeroPaths;

		internal TypeId TypeId;

		internal BitSet[] Filters;

		internal Priority[] PropertiesTempPriority;

		internal NetworkPropertyInfo[] Properties;

		internal HashSet<string> CallbackPaths;

		internal Stack<NetworkStorage> StoragePool;

		internal List<NetworkPropertyInfo> OnRender;

		internal List<NetworkPropertyInfo> OnSimulateAfter;

		internal List<NetworkPropertyInfo> OnSimulateBefore;

		internal List<NetworkPropertyInfo> OnControlGainedLost;

		internal List<NetworkPropertyInfo> OnFrameCloned;

		internal int CountObjects;

		internal int CountStorage;

		internal int CountProperties;

		internal NetworkObj_Meta()
		{
		}

		internal NetworkStorage AllocateStorage()
		{
			return null;
		}

		internal void FreeStorage(NetworkStorage storage)
		{
		}

		private void AddPropertyToArray(int offsetProperties, int offsetObjects, NetworkProperty property)
		{
		}

		internal void AddProperty(int offsetProperties, int offsetObjects, NetworkProperty property, int arrayIndex)
		{
		}

		private void AddCopiedProperty(int offsetProperties, int offsetObjects, NetworkPropertyInfo property, string prefix, int arrayIndex)
		{
		}

		internal void CopyProperties(int offsetProperties, int offsetObjects, NetworkObj_Meta meta, string prefix, int arrayIndex)
		{
		}

		internal abstract void InitObject(NetworkObj obj, Offsets offsets);

		internal virtual void InitMeta()
		{
		}

		internal void InitObject(NetworkObj obj, NetworkObj root, Offsets offsets)
		{
		}
	}
}
