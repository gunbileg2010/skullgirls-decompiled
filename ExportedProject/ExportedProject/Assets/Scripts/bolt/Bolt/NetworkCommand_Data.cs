using System.Runtime.CompilerServices;

namespace Bolt
{
	internal abstract class NetworkCommand_Data : NetworkObj, INetworkCommandData
	{
		public IProtocolToken Token
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

		internal Command RootCommand => null;

		private IProtocolToken Bolt_002EINetworkCommandData_002EToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal NetworkCommand_Data(NetworkObj_Meta meta)
			: base(null)
		{
		}
	}
}
