using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Open.Nat
{
	public class Mapping
	{
		private DateTime _expiration;

		private int _lifetime;

		internal MappingLifetime LifetimeType
		{
			[CompilerGenerated]
			get
			{
				return default(MappingLifetime);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public IPAddress PrivateIP
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Protocol Protocol
		{
			[CompilerGenerated]
			get
			{
				return default(Protocol);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int PrivatePort
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public IPAddress PublicIP
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int PublicPort
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int Lifetime
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public DateTime Expiration
		{
			get
			{
				return default(DateTime);
			}
			internal set
			{
			}
		}

		internal Mapping(Protocol protocol, IPAddress privateIP, int privatePort, int publicPort)
		{
		}

		public Mapping(Protocol protocol, IPAddress privateIP, int privatePort, int publicPort, int lifetime, string description)
		{
		}

		public Mapping(Protocol protocol, int privatePort, int publicPort)
		{
		}

		public Mapping(Protocol protocol, int privatePort, int publicPort, string description)
		{
		}

		public Mapping(Protocol protocol, int privatePort, int publicPort, int lifetime, string description)
		{
		}

		internal Mapping(Mapping mapping)
		{
		}

		public bool IsExpired()
		{
			return false;
		}

		public bool IsAboutToExpire()
		{
			return false;
		}

		internal bool ShoundRenew()
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
