using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Bolt
{
	internal sealed class CommandHistory
	{
		private class CommandRecord : IBoltListNode<CommandRecord>
		{
			internal int Sequence;

			internal NetworkStorage Storage;

			private static readonly ObjectPool<CommandRecord> m_Pool;

			private CommandRecord IBoltListNode_003CBolt_002ECommandHistory_002ECommandRecord_003E_002Eprev
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

			private CommandRecord IBoltListNode_003CBolt_002ECommandHistory_002ECommandRecord_003E_002Enext
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

			private object IBoltListNode_003CBolt_002ECommandHistory_002ECommandRecord_003E_002Elist
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

			internal static CommandRecord Get(int sequence, NetworkStorage storage)
			{
				return null;
			}

			internal void Return()
			{
			}
		}

		private Dictionary<int, BoltDoubleList<CommandRecord>> m_Records;

		private Dictionary<int, int> m_InvalidSequences;

		private Dictionary<int, int> m_FullSyncCounters;

		private int m_MaxRecordsPerCommandType;

		internal CommandHistory(int maxRecordsPerCommandType)
		{
		}

		internal int GetSequenceForSmallestDiff(Command command, NetworkCommand_Data data)
		{
			return 0;
		}

		internal NetworkStorage GetStorageForSequence(int commandType, int sequence)
		{
			return null;
		}

		internal void Add(Command command)
		{
		}

		internal bool Contains(Command command)
		{
			return false;
		}

		internal bool Remove(Command command, int sequence)
		{
			return false;
		}

		internal bool ShouldDeltaCompress(int commandType, int fullSyncSendRate)
		{
			return false;
		}

		internal void SetInvalidSequence(int commandType, int sequence)
		{
		}

		internal int GetAndRemoveInvalidSequence(int commandType)
		{
			return 0;
		}
	}
}
