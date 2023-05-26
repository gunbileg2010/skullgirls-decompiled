using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Open.Nat
{
	public abstract class NatDevice
	{
		private readonly HashSet<Mapping> _openedMapping;

		protected DateTime LastSeen
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal void Touch()
		{
		}

		public abstract Task CreatePortMapAsync(Mapping mapping);

		public abstract Task DeletePortMapAsync(Mapping mapping);

		public abstract Task<IEnumerable<Mapping>> GetAllMappingsAsync();

		public abstract Task<IPAddress> GetExternalIPAsync();

		public abstract Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int port);

		protected void RegisterMapping(Mapping mapping)
		{
		}

		protected void UnregisterMapping(Mapping mapping)
		{
		}

		internal void ReleaseMapping(IEnumerable<Mapping> mappings)
		{
		}

		internal void ReleaseAll()
		{
		}

		internal void ReleaseSessionMappings()
		{
		}

		internal Task RenewMappings()
		{
			return null;
		}

		private Task RenewMapping(Mapping mapping)
		{
			return null;
		}
	}
}
