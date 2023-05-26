using System.Runtime.CompilerServices;
using UdpKit;

namespace Bolt
{
	[Documentation]
	public abstract class Event : NetworkObj_Root
	{
		internal const byte ENTITY_EVERYONE = 1;

		internal const byte ENTITY_EVERYONE_EXCEPT_OWNER = 3;

		internal const byte ENTITY_EVERYONE_EXCEPT_OWNER_AND_CONTROLLER = 13;

		internal const byte ENTITY_EVERYONE_EXCEPT_CONTROLLER = 5;

		internal const byte ENTITY_ONLY_CONTROLLER = 7;

		internal const byte ENTITY_ONLY_CONTROLLER_AND_OWNER = 15;

		internal const byte ENTITY_ONLY_OWNER = 9;

		internal const byte ENTITY_ONLY_SELF = 11;

		internal const byte GLOBAL_EVERYONE = 2;

		internal const byte GLOBAL_OTHERS = 4;

		internal const byte GLOBAL_ONLY_SERVER = 6;

		internal const byte GLOBAL_ALL_CLIENTS = 8;

		internal const byte GLOBAL_SPECIFIC_CONNECTION = 10;

		internal const byte GLOBAL_ONLY_SELF = 12;

		internal const int RELIABLE_WINDOW_BITS = 10;

		internal const int RELIABLE_SEQUENCE_BITS = 12;

		private NetworkStorage storage;

		internal uint Sequence;

		internal ReliabilityModes Reliability;

		internal int Targets;

		internal bool Reliable;

		internal Entity TargetEntity;

		internal BoltConnection TargetConnection;

		internal BoltConnection SourceConnection;

		internal new Event_Meta Meta;

		public bool FromSelf => false;

		public BoltConnection RaisedBy => null;

		public bool IsGlobalEvent => false;

		internal override NetworkStorage Storage => null;

		public byte[] BinaryData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool IsEntityEvent => false;

		internal Event(Event_Meta meta)
			: base(null)
		{
		}

		internal void InitNetworkStorage()
		{
		}

		internal void FreeStorage()
		{
		}

		internal bool Pack(BoltConnection connection, UdpPacket packet)
		{
			return false;
		}

		internal void Read(BoltConnection connection, UdpPacket packet)
		{
		}

		public void Send()
		{
		}
	}
}
