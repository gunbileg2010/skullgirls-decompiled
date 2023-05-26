namespace Bolt.Exceptions
{
	public class BoltAssertFailedException : BoltException
	{
		public BoltAssertFailedException(string msg = "")
			: base(null, null)
		{
		}
	}
}
