using System.Threading;

namespace Bolt
{
	internal abstract class ControlCommand
	{
		public int PendingFrames;

		public int FinishedFrames;

		public ControlState State;

		public ManualResetEvent FinishedEvent;

		public ControlCommand()
		{
		}

		public abstract void Run();

		public abstract void Done();
	}
}
