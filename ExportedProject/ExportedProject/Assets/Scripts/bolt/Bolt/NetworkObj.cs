using System.Collections.Generic;

namespace Bolt
{
	public abstract class NetworkObj
	{
		internal string Path;

		internal NetworkObj Root;

		internal List<NetworkObj> RootObjects;

		internal readonly NetworkObj_Meta Meta;

		internal int OffsetObjects;

		internal int OffsetStorage;

		internal int OffsetProperties;

		internal NetworkState RootState => null;

		internal List<NetworkObj> Objects => null;

		internal virtual NetworkStorage Storage => null;

		internal int Item => 0;

		internal void Add()
		{
		}

		internal NetworkObj(NetworkObj_Meta meta)
		{
		}

		internal void InitRoot()
		{
		}

		internal void Init(string path, NetworkObj parent, NetworkObj_Meta.Offsets offsets)
		{
		}

		internal NetworkStorage AllocateStorage()
		{
			return null;
		}

		internal NetworkStorage DuplicateStorage(NetworkStorage srcStorage)
		{
			return null;
		}

		internal void FreeStorage(NetworkStorage storage)
		{
		}
	}
}
