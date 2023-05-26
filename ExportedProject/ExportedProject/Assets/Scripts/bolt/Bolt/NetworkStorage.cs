using System.Runtime.CompilerServices;

namespace Bolt
{
	internal class NetworkStorage : BitSet, IBoltListNode<NetworkStorage>
	{
		public int Frame;

		public NetworkObj Root;

		public NetworkValue[] Values;

		private NetworkStorage IBoltListNode_003CBolt_002ENetworkStorage_003E_002Eprev
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

		private NetworkStorage IBoltListNode_003CBolt_002ENetworkStorage_003E_002Enext
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

		private object IBoltListNode_003CBolt_002ENetworkStorage_003E_002Elist
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

		public NetworkStorage(int size)
			: base(0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL)
		{
		}

		public void PropertyChanged(int property)
		{
		}
	}
}
