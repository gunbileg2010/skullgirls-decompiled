namespace Bolt
{
	internal struct CommandCallbackItem
	{
		public int End;

		public int Start;

		public Command Command;

		public CommandCallback Callback;

		public CommandCallbackModes Mode;
	}
}
