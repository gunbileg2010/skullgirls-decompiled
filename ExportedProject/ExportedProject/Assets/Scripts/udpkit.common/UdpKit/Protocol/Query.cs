namespace UdpKit.Protocol
{
	internal abstract class Query : Message
	{
		public Result Result;

		public bool HasResult => false;

		public bool Failed => false;

		public virtual bool IsUnique => false;

		public virtual bool Resend => false;

		public virtual uint BaseTimeout => 0u;
	}
	internal abstract class Query<TResult> : Query where TResult : Result
	{
		public new TResult Result => null;
	}
}
